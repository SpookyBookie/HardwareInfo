
namespace ConsoleApplication90
{
    abstract class BaseHardware
    {
        protected iName _name;
        protected iArchitecture _architecture;


        public BaseHardware()
        {
            _name = new NullName();
            _architecture = new NullArchitecture();
        }


        public abstract void GetArchitecture();
        public abstract void GetName();
        public abstract void GetDeviceParameters();
    }    
}