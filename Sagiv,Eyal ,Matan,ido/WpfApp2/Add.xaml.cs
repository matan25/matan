using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        BarberingEntities db = new BarberingEntities();

        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string adress = TbAdress.Text;
            string sex = TbSex.Text;
            string phone = TbPhone.Text;
            string name = TbName.Text;

            db.Barber.Add(new Barber { Adress = adress, Sex = sex, Phone = phone, Name = name });
            db.SaveChanges();
        }
    }
}
