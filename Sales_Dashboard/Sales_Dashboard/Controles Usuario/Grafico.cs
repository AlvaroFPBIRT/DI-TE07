using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sales_Dashboard.Controles_Usuario
{
    public partial class Grafico : UserControl
    {
        public Grafico()
        {
            InitializeComponent();
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void rellenarchartTotal(int[] datos)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            Title title = new Title();
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.Text = "Facturación Total a cada Empresa";
            chart1.Titles.Add(title);
            chart1.Series.Add("Total Anual");

            
            for (int i = 0; i < datos.Length; i++)
            {
                chart1.Series["Total Anual"].Points.AddXY("Empresa " + (i + 1), datos[i]);
            }
        }

        public void rellenarchartMeses(int[] datosEmpresa1, int[] datosEmpresa2)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            Title title = new Title();
            title.Font = new Font("Arial", 12, FontStyle.Bold);
            title.Text = "Facturación por Meses a cada Empresa";
            chart1.Titles.Add(title);
            chart1.Series.Add("Empresa1");
            chart1.Series.Add("Empresa2");
            //
            ChartArea ca1 = chart1.ChartAreas[0];

            // the regular axis label interval and range
            ca1.AxisX.Interval = 1;
            ca1.AxisX.Minimum = 0;
            ca1.AxisX.Maximum = 13;

            


            for (int i = 0; i < datosEmpresa1.Length; i++)
            {
                chart1.Series["Empresa1"].Points.AddXY("" + (i + 1), datosEmpresa1[i]);
                chart1.Series["Empresa2"].Points.AddXY("" + (i + 1), datosEmpresa2[i]);
            }
        }
    }
}
