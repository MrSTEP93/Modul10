using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10.Task3
{

    public interface IWriter
    {
        void Write()
        {
            Console.WriteLine("Now we write to FILE!");
        }
    }

    public interface IReader
    {
        void Read()
        {
            Console.WriteLine("All we read is FILE!");
        }
    }

    public interface IMailer
    {
        void SendEmail()
        {
            Console.WriteLine("You can mail us");
        }
    }

    public class FileManager : IWriter, IReader, IMailer
    {

    }
}
