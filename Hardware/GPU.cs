using System;

namespace ConsoleApplication90
{
    class GPU : BaseHardware
    {
        public GPU() : base()
        {
            _name = new GPUName();
            _architecture = new GPUArchitecture();
        }


        public override void GetArchitecture()
        {
            Console.Write(_architecture.GetArchitecture() + " ");
        }

        public override void GetName()
        {
            Console.Write(_name.GetName() + " ");
        }

        public override void GetDeviceParameters()
        {
            this.GetArchitecture();
            this.GetName();
            Console.WriteLine();
        }
    }
}
