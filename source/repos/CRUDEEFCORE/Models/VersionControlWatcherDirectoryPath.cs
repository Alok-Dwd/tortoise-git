using System;
using System.Collections.Generic;

namespace CRUDEEFCORE.Models
{
    public partial class VersionControlWatcherDirectoryPath
    {
        public int Id { get; set; }
        public string DirectoryPath { get; set; }
        public string ProjectName { get; set; }
        public bool? Active { get; set; }
        public DateTime? AddedDate { get; set; }
    }
}
