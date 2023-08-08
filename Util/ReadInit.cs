using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniModificator.Util
{
    public class ReadInit
    {

        public string initPath { get; set; }
        public List<string> lines { get; set; } = new List<string>();
        public ReadInit(string path) {
            initPath = path;
            lines = File.ReadAllLines(initPath).ToList();
        }









    }
}
