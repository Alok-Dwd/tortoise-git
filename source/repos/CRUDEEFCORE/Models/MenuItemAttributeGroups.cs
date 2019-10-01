using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class MenuItemAttributeGroups
    {
        public string LocationCode { get; set; }
        public string MenuCode { get; set; }
        public string AttributeGroupCode { get; set; }
        public int MinToChoose { get; set; }
        public int MaxToChoose { get; set; }
        public int DisplayOrder { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
