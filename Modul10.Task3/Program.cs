using System;

namespace Modul10.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunFileMan();

            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();

            viberInPhone.DeviceInfo();
            viberInIPhone.DeviceInfo();

            Console.Read();

        }

        private static void RunFileMan()
        {
            Console.WriteLine("Hello World!");
            var fileMan = new FileManager();
            ((IReader)fileMan).Read();
        }
    }
}
