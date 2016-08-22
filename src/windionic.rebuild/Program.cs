using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

using windionic.exportbase;

namespace windionic.rebuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetAssembly = typeof(MyFirstWindionic.DeviceInfo).Assembly;
            var script = TsBuilder.Build(targetAssembly);

            File.WriteAllText("C:\\Users\\hyun\\Documents\\Visual Studio 2015\\Projects\\CordovaApp\\IonicApp2\\typings\\bridge.d.ts",
                script);
            File.Copy(
                targetAssembly.Location,
                "C:\\Users\\hyun\\Documents\\Visual Studio 2015\\Projects\\AwesomeApp\\AwesomeApp\\bin\\Debug\\asm.dll",
                true);
        }
    }

    
}
