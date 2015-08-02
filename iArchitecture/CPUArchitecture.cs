using System;
using System.Management;
using System.Text;

namespace ConsoleApplication90
{
    class CPUArchitecture : iArchitecture
    {
        enum ArcType { x86 = 0 , MIPS = 1, Alpha = 2, PowerPC = 3, ARM = 5, ia64 = 6, x64 = 9 };

        public string GetArchitecture()
        {
            int _arcNumber;

            ManagementObjectSearcher _arcSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (var data in _arcSearcher.Get())
            {
                _arcNumber = Convert.ToInt32(data.GetPropertyValue("Architecture"));
                
                return Enum.GetName(typeof(ArcType), _arcNumber);
            }

            return "null";
        }
    }
}
