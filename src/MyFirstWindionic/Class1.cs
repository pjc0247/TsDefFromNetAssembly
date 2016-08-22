using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using windionic.exportbase;

namespace MyFirstWindionic
{
    [Export]
    public class DeviceInfo
    {
        public static string dump()
        {
            return
                $"Machine : {Environment.MachineName}\r\n" +
                $"OS : {Environment.OSVersion}";
        }

        public static string osVersion()
        {
            return Environment.OSVersion.ToString();
        }
        public static string machineName()
        {
            return Environment.MachineName;
        }
        public static string userName()
        {
            return "jwg0422";
            //return Environment.UserName;
        }
        public static int processorCount()
        {
            return Environment.ProcessorCount;
        }
    }

    [Export]
    public class Mathf
    {
        public static float sum(int a, int b)
         => a + b;
    }
}
