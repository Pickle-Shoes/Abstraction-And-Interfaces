using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_And_Interfaces.Logger
{

    //file based logger that implements ILogger
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Writing {message} to file.");

            using(StreamWriter writer = File.CreateText("Log.txt"))
            {
                writer.WriteLine($"{message}");
            }
        }
    }
}
