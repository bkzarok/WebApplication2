using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Data
{
    public class WebCamOptions
    {

        public int Width { get; set; } = 320;
        public string VideoID { get; set; }
        public string CanvasID { get; set; }
        public string PhotoID { get; set; }
       // public int Height { get; set; } = 320;
        public string Filter { get; set; } = null;
    }
}
