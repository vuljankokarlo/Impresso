using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManual
{
    /// <summary>
    /// <author>Stefan Tropčić</author>
    /// </summary>
    public class Pdf
    {
        /// <summary>
        /// otvara pdf user manual, sprema ga u pomocni i otvara ovisno 
        /// o proslijedenoj stranici forme u user manualu
        /// </summary>
        /// <param name="broj"></param>
        public static void OtvoriPodrsku(int broj)
        {
            Byte[] bytes = Properties.Resources.User_manual;

            using (FileStream fs = File.Create("Korisnicki_prirucnik.pdf"))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            Process process1 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();

            process1.StartInfo = startInfo;
            startInfo.Arguments = "/A \"page=" + broj.ToString() + "=OpenActions\" Korisnicki_prirucnik.pdf";
            startInfo.FileName = "AcroRd32.exe";
            process1.Start();

        }
    }
}
