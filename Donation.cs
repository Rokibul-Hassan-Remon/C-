using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masjid_Management
{
    public abstract class Donation
    {
        public int amount { get; set; }
        public Donation(int tk)
        {
            amount = tk;
            
        }

        public abstract void donarInfo();
    }
}
