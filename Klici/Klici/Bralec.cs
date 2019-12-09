using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Klici
{
    class Bralec
    {
        FileStream fs;
        StreamReader sr;
        uint število; //prvo število v datoteki
        public void Odpri (string imeD)
        {
            fs = new FileStream(imeD, FileMode.Open);
            sr = new StreamReader(fs);
            try
            {
                string prva = sr.ReadLine();
                število = uint.Parse(prva);
            }
            catch(FormatException e)
            {
                throw new VročiKliciException("Prvo število ni celo pozitivno ", e);
            }
        }
        public uint NOseb
        {
            get { return število; }
        }
        public void ObravnavajNaslednjega()
        {
            try
            {
                string ime = sr.ReadLine();
                if (ime == null)
                    throw new VročiKliciException("Ni dovolj imen");
                if (ime[0] == 'Z')
                    throw new TajniAgentException(ime);
                Console.WriteLine(ime);
            }
            catch(TajniAgentException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
