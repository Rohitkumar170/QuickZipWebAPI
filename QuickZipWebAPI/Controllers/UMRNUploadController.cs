using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Data;
using System.IO;
using ExcelDataReader;
using System.Net.Http;
using System.Web.Http;
using QuickZipWebAPI.Entity;
using System.Xml;
using System.Xml.Serialization;
using QuickZipWebAPI.Models;
using System.Web;

using QuickZipWebAPI.Models.UMRNUpload;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.OleDb;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Data.SqlClient;

namespace QuickZipWebAPI.Controllers
{
    public class UMRNUploadController : ApiController
    {
        UMRNUpload umrn = new UMRNUpload();

        System.Data.DataTable dt = new System.Data.DataTable();
        // QuickCheckEmandate_AngularEntities dbcontext = new QuickCheckEmandate_AngularEntities();
        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/UMRNUpload/BindGrid/{EntityId}")]
        public Dictionary<string, object> BindGrid( string EntityId)
        {

            return umrn.BindGrid( EntityId);
        }



        [HttpGet]
     
        [Route("api/UMRNUpload/BindOnRowdblClick/{UploadHeaderId}")]
        public Dictionary<string, object> BindOnRowdblClick(string UploadHeaderId)
        {

            return umrn.BindOnRowdblClick(UploadHeaderId);
        }

        [HttpPost]
        [Route("api/UMRNUpload/UploadExcel/{UserId}/{EntityId}")]
        public Dictionary<string, object> UploadExcel(string UserId, string EntityId)
        {
            
            string message = "";
            string FileName1 = "";
            HttpResponseMessage result = null;
            var httpRequest = HttpContext.Current.Request;
            DataSet excelRecords = new DataSet();
           

                if (httpRequest.Files.Count > 0)
                {
                    HttpPostedFile file = httpRequest.Files[0];
                    Stream stream = file.InputStream;

                    IExcelDataReader reader = null;

                string eid1 = DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")));
               
             
                string FileName = Path.GetFileName(file.FileName);
                 FileName1 = Path.GetFileName(file.FileName);

                string Extension = Path.GetExtension(file.FileName);
                Regex illegalInFileName = new Regex(@"[\\/:*?""<>|]");
             

                string FolderPath = HttpContext.Current.Server.MapPath("/ExportedFiles");

              

                string FilePath = FolderPath + '/' +   FileName;
                    if (!Directory.Exists(FolderPath))   // CHECK IF THE FOLDER EXISTS. IF NOT, CREATE A NEW FOLDER.
                    {
                        Directory.CreateDirectory(FolderPath);
                    }

                    if (File.Exists(FilePath))
                    {
                        File.Delete(FilePath);
                    }

                    file.SaveAs(FilePath);

                    
                    if (Extension == ".xls")
                    {
                        FilePath = FilePath.Replace(".xls", ".xlsx");
                      
                        if (File.Exists(FilePath))
                        {
                            File.Delete(FilePath);
                        }
                        FilePath = FilePath.Replace(".xlsx", ".xls");
                        FileInfo f = new FileInfo(FilePath);
                        f.MoveTo(Path.ChangeExtension(FilePath, ".xlsx"));
                        Extension = ".xlsx";
                        FilePath = FilePath.Replace(".xls", ".xlsx");
                    }

                    string conStr = "";
                    if (Extension == ".xls" || Extension == ".xlsx")
                    {
                        switch (Extension)
                        {
                            case ".xls": //Excel 97-03
                                conStr = System.Configuration.ConfigurationManager.ConnectionStrings["Excel03ConString"]
                                         .ConnectionString;
                                break;
                            case ".xlsx": //Excel 07
                                conStr = System.Configuration.ConfigurationManager.ConnectionStrings["Excel07ConString"]
                                          .ConnectionString;
                                break;
                        }


                    conStr = String.Format(conStr, FilePath, true);
                    OleDbConnection connExcel = new OleDbConnection(conStr);
                    OleDbCommand cmdExcel = new OleDbCommand();
                    OleDbDataAdapter oda = new OleDbDataAdapter();

                    cmdExcel.Connection = connExcel;

                    //Get the name of First Sheet
                    connExcel.Open();
                    System.Data.DataTable dtExcelSchema;
                    dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string SheetName = dtExcelSchema.Rows[0]["Table_Name"].ToString();
                    connExcel.Close();
                    connExcel.Open();
                    cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";
                    oda.SelectCommand = cmdExcel;
                    oda.Fill(dt);
                    if (dt.Rows.Count == 0)
                    {
                        
                    }

                   
                    if (dt.Rows.Count > int.Parse(System.Configuration.ConfigurationManager.AppSettings["LegacyCount"]))
                    {
                        
                    }
                    connExcel.Close();

                }



                //excelRecords = reader.AsDataSet();
                //    reader.Close();

                   
                   
                
               
            }

                else
                {
                    result = Request.CreateResponse(HttpStatusCode.BadRequest);
                }

            return umrn.UploadExcel(GetXmlByDatable(dt), UserId,EntityId, FileName1);

        }
        public string GetXmlByDatable(DataTable dtObjectforXml)
        {
            if (dtObjectforXml == null)
                return "";
            if (dtObjectforXml.Rows.Count == 0)
                return "";

            if (dtObjectforXml.TableName == "")
                dtObjectforXml.TableName = "dtXml";

            XmlDocument objectXmlDocument = new XmlDocument();
            XmlElement objElement = objectXmlDocument.CreateElement(dtObjectforXml.TableName);

            for (int iRecordCounter = 0; iRecordCounter < dtObjectforXml.Rows.Count; iRecordCounter++)
            {
                // Generate XmlObject and Append Nodes by calling a Child function.
                objElement.AppendChild(BuildXmlElement(dtObjectforXml.Rows[iRecordCounter], objectXmlDocument));
            }

            objectXmlDocument.AppendChild(objElement);
            return objectXmlDocument.OuterXml;
        }
        private XmlElement BuildXmlElement(DataRow drObjectforXml, XmlDocument objectXmlDocument)
        {
            XmlElement XmlElement = objectXmlDocument.CreateElement(drObjectforXml.Table.TableName);
            for (int iColumnCounter = 0; iColumnCounter < drObjectforXml.Table.Columns.Count; iColumnCounter++)
            {
                XmlElement.SetAttribute(drObjectforXml.Table.Columns[iColumnCounter].ColumnName, Convert.ToString(drObjectforXml[iColumnCounter].ToString()));
            }

            return XmlElement;
        }


        [HttpGet]
        [Route("api/UMRNUpload/btnSave_Click/{EntityId}/{UserId}/{UploadHeaderId}/{TotalCount}/{validatedcount}/{FileName}")]
        public Dictionary<string, object> btnSave_Click(string EntityId, string UserId, string UploadHeaderId, string TotalCount, string validatedcount, string FileName)
        {

            return umrn.btnSave_Click(EntityId, UserId, UploadHeaderId, TotalCount, validatedcount, FileName);
        }
    }
}
