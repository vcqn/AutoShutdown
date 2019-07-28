using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_AutoShutdown
{
    public class ResxReader
    {
        private static ResourceManager Rm = new ResourceManager("UnitTest_AutoShutdown.Lang", Assembly.GetExecutingAssembly());

        public static string GetString(string name)
        {
            var content = Rm.GetString(name);
            return content;
        }
    }
}
