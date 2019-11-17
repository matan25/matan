using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class HairStyle
    {
        private string adress { get; set; }
        private string sex { get; set; }
        private string phone { get; set; }
        private string name { get; set; }

        public HairStyle(string adress,string sex,string phone,string name)
        {
            this.adress = adress;
            this.sex = sex;
            this.phone = phone;
            this.name = name;
        }
        public void Insert (string adress, string sex, string phone, string name)
        {
            HairStyle hs = new HairStyle(this.adress, this.sex, this.phone, this.name);
            BarberModel bm = new BarberModel();
            if(bm.validate(hs))
            {
                bm.Insert(hs);
            }
        }
    }
}
