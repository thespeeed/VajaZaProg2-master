using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klici
{
    class TajniAgentException:ApplicationException
    {
        public TajniAgentException(string sporočilo):base("Najden agent z imenom " + sporočilo)
        {

        }
    }
}
