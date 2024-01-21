using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFilesInFolder
{
    public class StyleDirectory
    {
        public string DirectoryName { get; set; }
        public List<Artist> Artists { get; set; }

        public StyleDirectory()
        {
            Artists = [];
            DirectoryName = string.Empty;
        }
    }
}
