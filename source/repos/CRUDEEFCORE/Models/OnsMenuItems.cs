using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class OnsMenuItems
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string MenuCategoryCode { get; set; }
        public string Description { get; set; }
        public string OrderDescription { get; set; }
        public int? DisplayOrder { get; set; }
        public int? MenuCategoryDisplayOrder { get; set; }
        public short? Taxable { get; set; }
        public bool? RoyaltyYn { get; set; }
        public bool? PreparedYn { get; set; }
        public bool? PizzaYn { get; set; }
        public bool? SpecialtyPizza { get; set; }
        public short? StatusCode { get; set; }
        public bool? TextColor { get; set; }
        public bool? PrintLabel { get; set; }
        public bool? TrackEmployeeSales { get; set; }
        public bool? PrintTicket { get; set; }
        public bool? PromptForSize { get; set; }
        public bool? ComboMeal { get; set; }
        public short? RemoteOrderAvailability { get; set; }
        public short? MenuItemTypeCode { get; set; }
        public byte[] MenuItemImage { get; set; }
        public bool? PrintNutritionalLabel { get; set; }
        public string AddedBy { get; set; }
        public string Added { get; set; }
    }
}
