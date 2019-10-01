﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class ProductsText
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public string ProductCode { get; set; }
        public string ProdTextProductDesc { get; set; }
        public string ProdTextDisplayCode { get; set; }
        public string ProdTextSizeDesc { get; set; }
        public string ProdTextFlavorDesc { get; set; }
        public string ProdTextOptSelectGrpDesc { get; set; }
        public string ProdTextCategoryDesc { get; set; }
        public string ProdTextSizeShortDesc { get; set; }
        public string ProdTextFlavorShortDesc { get; set; }
    }
}
