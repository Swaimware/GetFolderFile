﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFilesInFolder
{
    public class Artist
    {
        public string ArtistName { get; set; }
        public List<string> Albums { get; set; }
        public Artist()
        {
            Albums = [];
            ArtistName = string.Empty;
        }
    }
}
