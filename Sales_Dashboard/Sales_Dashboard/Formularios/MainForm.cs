using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sales_Dashboard.Controles_Usuario;
using SalesBLL;
using Utilidades;

namespace Sales_Dashboard.Formularios
{
    public partial class MainForm : Form
    {
        private TableLayoutPanel tlp;
        private Grafico grafico1;
        private Grafico grafico2;
        private InfoEmpleado infoEmpleado;
        private SalesBLLMVC unBLL;
        public MainForm()
        {
            InitializeComponent();
            tlp = tlp0;
            grafico1 = new Grafico();
            grafico2 = new Grafico();
            unBLL = new SalesBLLMVC();
            infoEmpleado = new InfoEmpleado();
            this.toolTip1.SetToolTip(this.comboBoxNombres, "Selecciona un empleado de la lista");
            this.toolTip1.SetToolTip(this.button1, "Click para cerrar el programa");
            this.toolTip1.SetToolTip(this.button2, "Click para ver los datos del empleado");
            this.toolTip1.SetToolTip(this.button3, "Click para ver la facturación por empresa");
            this.toolTip1.SetToolTip(this.button4, "Click para ver resumen de ventas");
        }

        private void RellenarComboBox()
        {
            List<Persona> lista = SalesBLLMVC.LeerEmpleados();
            comboBoxNombres.DataSource = lista;
            comboBoxNombres.ValueMember = "numComercial";
            comboBoxNombres.DisplayMember = "nombreCompleto";            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tlp1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 pop = new Form1();
            pop.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RellenarComboBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico1);
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(infoEmpleado);
            int numComercial = (int)comboBoxNombres.SelectedValue;
            int[] datos= unBLL.FacturacionTotalAnual(numComercial);
            grafico2.rellenarchartTotal(datos);
            tlp.Controls.Add(grafico2, 1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico1);
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(infoEmpleado);
            string texto= unBLL.DatosMostrarComercial((Persona)comboBoxNombres.SelectedItem);
            infoEmpleado.MostrarTexto(texto);
            tlp.Controls.Add(infoEmpleado, 1, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tlp.Controls.Remove(grafico1);
            tlp.Controls.Remove(grafico2);
            tlp.Controls.Remove(infoEmpleado);
            int numComercial = (int)comboBoxNombres.SelectedValue;
            int[] datosEmpresa1 = unBLL.FacturacionPorEmpresa(numComercial, 1);
            int[] datosEmpresa2 = unBLL.FacturacionPorEmpresa(numComercial, 2);
            grafico1.rellenarchartMeses(datosEmpresa1,datosEmpresa2);
            tlp.Controls.Add(grafico1, 1, 1);
        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CurrentDirectory = Directory.GetCurrentDirectory();
            Help.ShowHelp(this, @"file:..\..\..\Recursos\Dashboard.chm");
        }
    }
}
