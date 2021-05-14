using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Dashboard.Controles_Usuario
{
    public partial class InfoEmpleado : UserControl
    {
        public InfoEmpleado()
        {
            InitializeComponent();
        }

        public void MostrarTexto(string texto)
        {
            textBox1.Text = texto;
        }
    }
}
