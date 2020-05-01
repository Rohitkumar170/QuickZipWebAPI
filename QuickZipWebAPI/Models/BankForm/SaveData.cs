using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace QuickZipWebAPI.Models.BankForm
{
	public class SaveData
	{
        public string MandateMode { get; set; }
        public string Bankaccountno { get; set; }
        public string Catagorycode { get; set; }
        public string Mandatetype { get; set; }
        public string UMRN { get; set; }
        public string UMRNDATE { get; set; }
        public string Sponsorcode { get; set; }
        public string Utilitycode { get; set; }
        public string Authrizename { get; set; }
        public string Todebit { get; set; }
        public string Withbank { get; set; }
        public string Debittype { get; set; }
        public string IFSC { get; set; }
        public string MICR { get; set; }
        public string Frequency { get; set; }
        public string Amountrupees { get; set; }
        public string Amount { get; set; }
        public string Email { get; set; }
        public string Phoneno { get; set; }
        public string Refrence1 { get; set; }
        public string Refrence2 { get; set; }
        public string PeriodFrom { get; set; }
        public string PeriodTo { get; set; }
        public string Untillcancelled { get; set; }
        public string Customer1 { get; set; }
        public string Customer2 { get; set; }
        public string Customer3 { get; set; }
    }
    public class SaveData0
    {
        public string IFSCResult { get; set; }
    }
    public class SaveData1
    {
        public string MICRResult { get; set; }
    }
    public class SaveData2
    {
        public Nullable<Int64> MandateId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int result { get; set; }
    }
    public class SaveData3
    {
        public string Bank { get; set; }
    }
    public class SaveData4
    {
        public string mandateid { get; set; }
        public string MandateFreshId { get; set; }
        public Nullable<Int64> ActivityId { get; set; }
        public string IFSC { get; set; }
    }
    public class SaveData5
    {
        public Nullable<bool> IsLiveInNACH { get; set; }
    }
    public class SaveData6
    {
        public Nullable<bool> IsLiveIMPS { get; set; }
        public Nullable<bool> IsNachLive { get; set; }
        public Nullable<bool> is_enach_live { get; set; }
    }
    public class SaveData7
    {
        public Nullable<bool> IsPhysical { get; set; }
        public Nullable<bool> Enach { get; set; }
    }
    public class SaveData8
    {
        public int result { get; set; }
        public int Column1 { get; set; }
    }
}