using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class PostingDestinations
    {
        public string LocationCode { get; set; }
        public short LanguageCode { get; set; }
        public byte PostingDestination { get; set; }
        public string EnglishTextDescription { get; set; }
        public string Description { get; set; }
    }
}
