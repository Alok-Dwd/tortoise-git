using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class KeyboardLayout
    {
        public string LocationCode { get; set; }
        public string KeyboardKey { get; set; }
        public string ShiftKeyboardKey { get; set; }
        public short DisplayOrder { get; set; }
        public short KeyType { get; set; }
        public string AddedBy { get; set; }
        public DateTime Added { get; set; }
    }
}
