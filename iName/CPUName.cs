using System;
using System.Management;
using System.Text;

namespace ConsoleApplication90
{
    class CPUName : iName
    {
        public string GetName()
        {
            string _arcNumber;

            ManagementObjectSearcher _arcSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            foreach (var data in _arcSearcher.Get())
            {
                _arcNumber = Convert.ToString(data.GetPropertyValue("Name"));

                return _arcNumber;
            }

            return "null";
        }
    }
}
