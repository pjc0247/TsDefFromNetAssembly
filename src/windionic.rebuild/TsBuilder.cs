using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using windionic.exportbase;

namespace windionic.rebuild
{
    public class TsBuilder
    {
        public static string Build(Assembly exportAssembly)
        {
            var exports = exportAssembly
                .GetTypes()
                .Where(x => x.GetCustomAttribute<ExportAttribute>() != null);

            var gen = new Generator();

            foreach (var export in exports)
            {
                var methods = export
                    .GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod);
                var properties = export
                    .GetProperties(BindingFlags.Public | BindingFlags.Static);

                gen.AddKlass(export.Name, methods.ToList(), properties.ToList());
            }

            return gen.Generate();
        }
    }
}
