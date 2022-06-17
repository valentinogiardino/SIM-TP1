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
    public partial class Pantalla : Form
    {

        private Gestor gestor;

        public Gestor Gestor { get => gestor; set => gestor = value; }


        public Pantalla()
        {
            InitializeComponent();
            this.gestor = new Gestor(this);
        }


        private void Pantalla_Load(object sender, EventArgs e)
        {
            cmbIntervalos.Items.Add(5);
            cmbIntervalos.Items.Add(8);
            cmbIntervalos.Items.Add(10);
            cmbIntervalos.Items.Add(12);

            panel1.Visible = false;
            btnAsistido.Visible = false;
            btnLibre.Visible = false;


            lblRecomendaciones.Text = "Para lograr el período máximo N: " + Environment.NewLine + "  c debe ser relativamente primo a m";
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // se toman los datos de la pantalla

            bool modoAsistido = true;
            if (!btnAsistido.Checked)
            {
                modoAsistido = false;               
            }

            string metodo = "";

            if (btnLineal.Checked)
            {
                metodo = "Lineal";
            }

            if (btnMultiplicativo.Checked)
            {
                metodo = "Multiplicativo";
            }

            if (btnRandomLenguaje.Checked)
            {
                metodo = "Lenguaje";
            }



            int cantidadNumeros = int.Parse(txtCantidadNumeros.Text.ToString());
            int semilla = int.Parse(txtSemilla.Text.ToString());
            int k = int.Parse(txtK.Text.ToString());
            int g = int.Parse(txtG.Text.ToString());
            int c = int.Parse(txtC.Text.ToString());
            int cantidadDecimales = int.Parse(txtDecimales.Text.ToString());
            int cantidadIntervalos = int.Parse(cmbIntervalos.Text.ToString());
            

            gestor.generarNumeros(modoAsistido, metodo, cantidadNumeros, semilla, k, g, c, cantidadDecimales, cantidadIntervalos);
            gestor.generarReporte();
        }
    

        private void btnMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Text = "0";
            txtC.Visible = false;
            lblC.Visible = false;

            txtSemilla.Visible = true;
            lblSemilla.Visible = true;
            txtSemilla.Text = "";

            txtG.Visible = true;
            lblG.Visible = true;
            txtG.Text = "";

            txtK.Visible = true;
            lblK.Visible = true;
            txtK.Text = "";



            lblRecomendaciones.Text = "Para lograr ael período máximo N: " + Environment.NewLine + "  La semilla debe ser un número impar";
        }

        private void btnLineal_CheckedChanged(object sender, EventArgs e)
        {
            txtC.Text = "";
            txtC.Visible = true;
            lblC.Visible = true;

            txtSemilla.Visible = true;
            lblSemilla.Visible = true;
            txtSemilla.Text = "";

            txtG.Visible = true;
            lblG.Visible = true;
            txtG.Text = "";

            txtC.Visible = true;
            lblC.Visible = true;
            txtC.Text = "";

            txtK.Visible = true;
            lblK.Visible = true;
            txtK.Text = "";

            lblRecomendaciones.Text = "Para lograr el período máximo N: " + Environment.NewLine + "  c debe ser relativamente primo a m";
        }

        private void cmbIntervalos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGenerar.Enabled = true;
        }

        private void btnRandomLenguaje_CheckedChanged(object sender, EventArgs e)
        {
           
            txtSemilla.Visible = false;
            lblSemilla.Visible = false;
            txtSemilla.Text = "0";
            
            txtG.Visible = false;
            lblG.Visible = false;
            txtG.Text = "0";

            txtC.Visible = false;
            lblC.Visible = false;
            txtC.Text = "0";

            txtK.Visible = false;
            lblK.Visible = false;
            txtK.Text = "0";

            lblRecomendaciones.Text = "Ingrese la cantidad de numeros a generar: ";
        }
    }
}
