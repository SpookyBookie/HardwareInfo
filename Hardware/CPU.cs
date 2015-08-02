using System;

namespace ConsoleApplication90
{
    class CPU : BaseHardware
    {
        public CPU() : base()
        {
            _name = new CPUName();
            _architecture = new CPUArchitecture();
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
