using System;
using System.Management;
using System.Text;

namespace ConsoleApplication90
{
    class GPUArchitecture : iArchitecture
    {
        enum ArcType { Other = 1, Unknown = 2, CGA = 3, EGA = 4, VGA = 5, SVGA = 6, MDA = 7, HGC = 8, MCGA = 9,
                       EightFiveOneFourA = 10, XGA = 11, LinearFrameBuffer = 12, PCEightNine = 160 };

        public string GetArchitecture()
        {
            int _arcNumber;

            ManagementObjectSearcher _arcSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (var data in _arcSearcher.Get())
            {
                _arcNumber = Convert.ToInt32(data.GetPropertyValue("VideoArchitecture"));

                return Enum.GetName(typeof(ArcType), _arcNumber);
            }

            return "null";
        }
    }
}
