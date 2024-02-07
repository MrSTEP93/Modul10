using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Task3
{

    public interface IMessenger <out T>
    {
        T DeviceInfo();
    }

    public class Computer { }
    public class Phone { }
    public class IPhone : Phone { }

    public class Viber <T> :IMessenger <T> where T : Phone, new()
    {

        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }

    }
}
