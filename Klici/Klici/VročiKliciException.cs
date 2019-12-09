using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    class VročiKliciException:ApplicationException
    {
        public VročiKliciException(string sporočilo):base("Vroči klici " + sporočilo)
        {}

        public VročiKliciException(string sporočilo, Exception e):base("Vroči klici " + sporočilo,e)
        { }
    }
}
