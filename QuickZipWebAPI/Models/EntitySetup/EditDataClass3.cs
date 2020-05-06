using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EntitySetup
{
    public class EditDataClass3
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public Nullable<Int64> CountryId { get; set; }
        public Nullable<Int64> CityId { get; set; }
        public Nullable<Int64> StateId { get; set; }
        public string Mobile { get; set; }
        public string Pincode { get; set; }
    }
}