﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZipWebAPI.Models.EntityBankSetup
{
    public class Bank
    {
        public Nullable<double> SponsorBankCodeId { get; set; }
        public string SponsorBankName { get; set; }
    }
}