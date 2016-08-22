using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windionic.rebuild
{
    public partial class BridgeTemplate
    {
        public List<ExportData> exports { get; set; } = new List<ExportData>();
    }
    public class ExportData
    {
        public class MethodData
        {
            public string name { get; set; }
            public string returnType { get; set; }
            public List<Tuple<string, string>> parameters { get; set; } = new List<Tuple<string, string>>();
        }
        public class PropertyData
        {
            public string name { get; set; }
            public string type { get; set; }
        }

        public string name { get; set; }
        public List<MethodData> methods { get; set; } = new List<MethodData>();
        public List<PropertyData> properties { get; set; } = new List<PropertyData>();
    }
}

