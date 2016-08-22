using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace windionic.rebuild
{
    public class Generator
    {
        private class KlassInfo
        {
            public List<MethodInfo> methods { get; set; }
            public List<PropertyInfo> properties { get; set; }
        }

        private Dictionary<string, KlassInfo> exports { get; set; }

        public Generator()
        {
            exports = new Dictionary<string, KlassInfo>();
        }

        public void AddKlass(string klassName, List<MethodInfo> methods, List<PropertyInfo> properties)
        {
            exports[klassName] = new KlassInfo()
            {
                methods = methods,
                properties = properties
            };
        }
        public string Generate()
        {
            var template = new BridgeTemplate();
            
            foreach(var export in exports)
            {
                template.exports.Add(new ExportData()
                {
                    methods = export.Value.methods.Select(x =>
                    {
                        return new ExportData.MethodData()
                        {
                            name = x.Name,
                            returnType = TypenameCvt.GetJsTypename(x.ReturnType),
                            parameters = x.GetParameters()
                                .Select(y =>
                                    new Tuple<string, string>(
                                        y.Name,
                                        TypenameCvt.GetJsTypename(y.ParameterType)))
                                .ToList()
                        };
                    }).ToList(),
                    properties = export.Value.properties.Select(x =>
                    {
                        return new ExportData.PropertyData()
                        {
                            name = x.Name,
                            type = TypenameCvt.GetJsTypename(x.PropertyType)
                        };
                    }).ToList(),
                    name = export.Key
                });
            }

            return template.TransformText();
        }
    }
}
