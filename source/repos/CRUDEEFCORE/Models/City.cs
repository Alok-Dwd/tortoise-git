﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class City
    {
        public string LocationCode { get; set; }
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int RegionCode { get; set; }
        public float TaxRate1 { get; set; }
        public float TaxRate2 { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }

        public virtual LocationCodes LocationCodeNavigation { get; set; }
        public virtual Regions Regions { get; set; }
    }
}
