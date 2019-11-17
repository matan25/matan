using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class BarberModel
    {
        public bool Insert(HairStyle hs)
        {
            return validate(hs);
        }
        public bool validate(HairStyle hs)
        {
            return true;
        }
    }
}
