﻿using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class InventoryItemRecipeIngredients
    {
        public string LocationCode { get; set; }
        public string InventoryCode { get; set; }
        public string SubInventoryCode { get; set; }
        public float Amount { get; set; }
        public byte InventoryUnit { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
