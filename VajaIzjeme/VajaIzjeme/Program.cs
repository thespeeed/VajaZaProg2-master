using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIzjeme
{
    class Program
    {
        static void Main(string[] args)
        {
            string vnos;
            while (true)
            {
                try
                {
                    Console.Write("Vnesi število med 0 in 5 >");
                    vnos = Console.ReadLine();
                    if (vnos == "")
                        break;
                    int index = int.Parse(vnos);
                    if (index < 0 || index > 5)
                        throw new IndexOutOfRangeException("Napačno število " + index);
                    Console.WriteLine("Tvoje število je " + index);
                }
                catch (IndexOutOfRangeException a)
                {
                    Console.WriteLine(a.Message);
                }
                catch (Exception a)
                {
                    Console.WriteLine("Napaka, sporočilo napake " + a.Message);
                }
                catch
                {
                    Console.WriteLine("Prišlo je do druge napake");
                }
                finally
                {
                    Console.WriteLine("Hvala za vnos");
                    Console.ReadLine();
                }
            }
        }
    }
}
