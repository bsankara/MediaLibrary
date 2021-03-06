﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    class MediaFile
    {
        string fileName {get; set;}
        string path { get; set; }
        int lastPosition { get; set; }
        bool netWork { get; set; }
        bool video { get; set; }

        public MediaFile(string name, string filepath, int pos, bool isNetwork, bool isVideo)
        {
            fileName = name;
            path = filepath;
            lastPosition = pos;
            netWork = isNetwork;
            video = isVideo;
        }
    }
}
