using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFrom
{
    public class Data
    {
       public paging paging { get; set; }
       public Entry[] entries { get; set; }

    }
    public class paging
    {
        public int limit { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
    }
    public class Entry
    {
        public string title { get; set; }
        public string category { get; set; }
        public int top { get; set; }
        public string publication_date { get; set; }
        public string takendown_date { get; set; }
        public string app_publication_data { get; set; }
        public string app_takendown_data { get; set; }
        public string constants { get; set; }
        public string remark { get; set; }
        public Link[] links { get; set; }
        public File[] files { get; set; }

    }
    public class Link
    {
        public string title { get; set; }
        public string url { get; set; }
    }
    public class File
    {
        public string filename { get; set; }
        public string url { get; set; }

    }
}
