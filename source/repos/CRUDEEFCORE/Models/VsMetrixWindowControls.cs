using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VsMetrixWindowControls
    {
        public string LocationCode { get; set; }
        public string WindowName { get; set; }
        public string ControlName { get; set; }
        public string ControlMetric { get; set; }
        public string ControlValue { get; set; }
        public string ControlType { get; set; }
        public int LeftAlign { get; set; }
        public int TopAlign { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int? FontColor { get; set; }
        public bool? FontBold { get; set; }
        public string FontName { get; set; }
        public int? FontCharset { get; set; }
        public bool? FontItalic { get; set; }
        public decimal? FontSize { get; set; }
        public string FormatString { get; set; }
        public byte? TextAlign { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
    }
}
