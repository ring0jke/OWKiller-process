using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWKiller
{
    class Program
    {
      static   void kill()
        {
            foreach (var process in Process.GetProcessesByName("csgo"))
            {
                process.Kill();
                Console.WriteLine("Trying to kill CSGO");
            }
            foreach (var process in Process.GetProcessesByName("Overwatch"))
            {
                process.Kill();
                Console.WriteLine("Trying to kill OW");
            }
        }

        static void Main(string[] args)
        {

            kill();
            }

   
    }
}
