﻿using MultithreadDownload.Downloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadDownload.Events
{
    public class DownloadStateChangeEventArgs : EventArgs
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string Path { get; set; }

        public DownloadTaskState State { get; set; }

        public DownloadStateChangeEventArgs()
        {

        }

        public DownloadStateChangeEventArgs(string url,string path,string name, DownloadTaskState downloadTaskState)
        {
            this.Name = name;
            this.Url = url;
            this.Path = path;
            this.State = downloadTaskState;
        }
    }
    
}
