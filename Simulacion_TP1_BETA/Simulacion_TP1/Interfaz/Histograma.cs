using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_TP1.Controlador;

namespace Simulacion_TP1
{
    public partial class Histograma : Form
    {
        private Gestor gestor;
        public Histograma(Gestor gestor)
        {
            
            InitializeComponent();
            this.gestor = gestor;
        }

        private void Histograma_Load(object sender, EventArgs e)
        {
            this.reporteChiCuadrado.RefreshReport();
            CargarTablaNumerosGenerados(this.gestor.listaNumerosGenerados);
            CargarReporte();
            MostrarChiCuadrado();
        }

        private void CargarReporte()
        {
            DataTable tabla = gestor.generarTabla();
            ReportDataSource datos = new ReportDataSource("DataSet1", tabla);
            reporteChiCuadrado.LocalReport.ReportEmbeddedResource = "Simulacion_TP1.Interfaz.Informe.rdlc";
            reporteChiCuadrado.LocalReport.DataSources.Clear();
            reporteChiCuadrado.LocalReport.DataSources.Add(datos);
            reporteChiCuadrado.RefreshReport();
        }

        private void CargarTablaNumerosGenerados(List<double> listaNumerosGenerados)
        {
            for (int i = 0; i < listaNumerosGenerados.Count; i++)
            {
                gdrNumeroGenerados.Rows.Add(i + 1, listaNumerosGenerados[i]);
            }
        }

        private void MostrarChiCuadrado()
        {
            bool resultadoPruebaChiCuadrado = this.gestor.pruebaChiCuadrado();
            if (resultadoPruebaChiCuadrado)
            {
                lblChiCuadrado.Text = "Se rechaza la hipotesis de que la distribucion sea uniforme";
            }
            else
            {
                lblChiCuadrado.Text = "No se rechaza la hipotesis de que la distribucion sea uniforme";
            }

            lblEstadistico.Text = this.gestor.mostrarValoresChi()[0].ToString();
            lblValorTabulado.Text = this.gestor.mostrarValoresChi()[1].ToString();

        }
    }
}
