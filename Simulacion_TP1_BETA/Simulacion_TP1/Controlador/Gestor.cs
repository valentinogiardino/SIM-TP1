using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Simulacion_TP1.Clases;

namespace Simulacion_TP1.Controlador
{
    public class Gestor
    {
        private Pantalla pantalla;
        private Generador generador;        //guarda referencia al generador creado
        public List<double> listaNumerosGenerados;
        public int[] arregloFrecuencias;
        public List<double> listaIntervalos;
        private int cantidadNumerosSolicitados;
        private int cantidadDecimales;

        public Pantalla Pantalla { get => pantalla; set => pantalla = value; }


        public Gestor(Pantalla pantalla)
        {
            this.pantalla = pantalla;
        }

        //Crea un generador e invoca su metodo para generar numero
        public void generarNumeros(bool modoAsistido, string metodo, int cantidadNumeros, int semilla, int k, int g, int c, int cantidadDecimales, int cantidadIntervalos)
        {
            this.cantidadNumerosSolicitados = cantidadNumeros;
            this.cantidadDecimales = cantidadDecimales;
            this.generador = new Generador(modoAsistido, metodo, cantidadNumeros, semilla, k, g, c, cantidadDecimales, cantidadIntervalos);
            
            if (metodo == "Lenguaje")
            {
                this.listaNumerosGenerados = this.generador.generarLenguaje();
            }
            else
            {
                this.listaNumerosGenerados = this.generador.generarNumeros();
            }
            

            obtenerFrecuencias();
            pruebaChiCuadrado();
        }

        //invoca al metodo del generador para contabilizar las frecuencias
        public int[] obtenerFrecuencias()
        {
            this.listaIntervalos = this.generador.generarIntervalos();
            this.arregloFrecuencias = this.generador.contarFrecuencias(this.listaNumerosGenerados, this.listaIntervalos);
            return this.arregloFrecuencias;
        }


        public bool pruebaChiCuadrado()
        {
            return generador.pruebaChiCuadrado(this.arregloFrecuencias);
        }

        public double[] mostrarValoresChi()
        {
            double[] valores = new double[2];
            double estadistico = this.generador.valorEstadisticoPrueba;
            double valorTabulado = this.generador.obtenerValorCriticoTabulado();

            valores[0] = estadistico;
            valores[1] = valorTabulado;

            return valores;
        }

        public void generarReporte()
        {
            Histograma pantallaReporte = new Histograma(this);
            pantallaReporte.ShowDialog();
        }

        public DataTable generarTabla()
        {
            DataTable tabla = new DataTable();
            DataColumn columna1 = new DataColumn("Intervalo");
            DataColumn columna2 = new DataColumn("FO");
            DataColumn columna3 = new DataColumn("FE");
            tabla.Columns.Add(columna1);
            tabla.Columns.Add(columna2);
            tabla.Columns.Add(columna3);

            double amplitud = (double)1 / this.arregloFrecuencias.Length;
            
            string frecuenciaEsperada = ((double)cantidadNumerosSolicitados / (double)this.arregloFrecuencias.Length).ToString();
            string frecuenciaEsperada2 = frecuenciaEsperada.Replace(",", ".");

            string UiRegion = Thread.CurrentThread.CurrentUICulture.Name;

            for (int i = 0; i < this.arregloFrecuencias.Length; i++)
            {
                DataRow row = tabla.NewRow();
                double limiteInferior = Math.Round((this.listaIntervalos[i] - amplitud), this.cantidadDecimales);
                row["Intervalo"] = limiteInferior.ToString() + " - " + this.listaIntervalos[i].ToString();
                row["FO"] = this.arregloFrecuencias[i];
                if (UiRegion == "es-ES")
                {
                    row["FE"] = frecuenciaEsperada;
                }
                else
                {
                    row["FE"] = frecuenciaEsperada2;
                }
                tabla.Rows.Add(row);
            }

            return tabla;   
        }
        

    }
}
