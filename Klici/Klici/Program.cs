using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    class Program
    {
        static void Main(string[] args)
        {
            string imeD;
            Console.Write("Vnesi ime datoteke >");
            imeD = Console.ReadLine();
            Bralec osebe = new Bralec();
            try
            {
                osebe.Odpri(imeD);
                for (int k = 0; k<osebe.NOseb;k++)
                {
                    osebe.ObravnavajNaslednjega();
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ni datoteke");
            }
            catch (VročiKliciException a)
            {
                Console.WriteLine("Napačna struktura datoteke");
                Console.WriteLine("Podrobnosti " + a.Message);
                if (a.InnerException != null)
                {
                    Console.WriteLine("Notranja napaka " + a.InnerException.Message);
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Prišlo je do druge napake " + x.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
