using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoverAttachments
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TicketDesk())
            {
                foreach (var ta in db.TicketAttachments)
                {
                    var path = Path.Combine(Properties.Settings.Default.OutputFolder, ta.TicketId.ToString());
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    File.WriteAllBytes(Path.Combine(path, ta.FileName), ta.FileContents);
                    Console.WriteLine($"Ticket: {ta.TicketId} - File: {ta.FileName}");
                }
            }

            Console.WriteLine("Operazione terminata.\r\nPremere un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
