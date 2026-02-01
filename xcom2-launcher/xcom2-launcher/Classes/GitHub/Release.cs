using System;
using System.Collections.Generic;

namespace XCOM2Launcher.GitHub
{
    public class Release
    {
        public string html_url { get; set; }
        public string tag_name { get; set; }
        public string name { get; set; }
        public bool prerelease { get; set; }
        public DateTime published_at { get; set; }
        public List<Asset> assets { get; set; }
        public string body { get; set; }
    }
}
