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
using dinamica.erp.wpf.Models;

namespace dinamica.erp.wpf
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            var users = new List<User>();

            for (int i = 0; i < 100; i++)
            {
                users.Add(new User
                {
                    Nombre = "Armando",
                    Apellido = "Meabe",
                    Contraseña = "cervezaogaseosa",
                    Teléfono = "4550055",
                    URL_Foto = "http://www.dinamicasoftware.com"
                });
            }

            DataGrid1.ItemsSource = users;
        }
    }
}
