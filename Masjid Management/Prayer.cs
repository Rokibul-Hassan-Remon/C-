using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    internal class Prayer : People
    {
        public Prayer(string name, string position, int donate) : base(name, position, donate)
        {
            
        }

        public Prayer(string name, string position) : base(name, position, 0)
        {

        }
    }
}
