using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_TP1.Clases
{
    public class Generador
    {   //Atributos del generador
        private int semilla;
        private int a;
        private int c;
        private long m;
        private int cantidadDecimales;
        private int cantidadIntervalos;
        private int cantidadNumerosSolicitados;
        public double valorEstadisticoPrueba;
        



        public Generador(bool modoAsistido, string metodo, int cantidadNumeros, int semilla, int k, int g, int c, int cantidadDecimales, int cantidadIntervalos)
        {
            if (metodo == "Lineal")
            {
                congruencialLineal(semilla, cantidadNumeros, k, g, c, cantidadDecimales, cantidadIntervalos);
            }
            if (metodo == "Multiplicativo")
            {
                congruencialMultiplicativo(semilla, cantidadNumeros, k, g, cantidadDecimales, cantidadIntervalos);
            }
            if (metodo == "Lenguaje")
            {
                lenguaje(cantidadNumeros, cantidadDecimales, cantidadIntervalos);
            }



        }

        // Define un constructor. Setea el generador asegurandose que cada parametro cumple los criterios para que el GENERADOR LINEAL sea optimo.
        
        private void congruencialLineal(int semilla, int cantidadNumeros, int k, int g, int c, int cantidadDecimales, int cantidadIntervalos)
        {
            this.semilla = semilla;
            this.a = 1 + 4 * k;
            this.m = (long) Math.Pow(2, g);         //calcula m a partir de los numeros a genererar, asegurando que sea 2^g
            this.c = c;
            this.cantidadDecimales = cantidadDecimales;
            this.cantidadIntervalos = cantidadIntervalos;
            this.cantidadNumerosSolicitados = cantidadNumeros;
        }

        private void lenguaje(int cantidadNumeros, int cantidadDecimales, int cantidadIntervalos)
        {
            this.cantidadDecimales = cantidadDecimales;
            this.cantidadIntervalos = cantidadIntervalos;
            this.cantidadNumerosSolicitados = cantidadNumeros;
        }

        public List<double> generarLenguaje()
        {
            
            double ajusteCantidadDecimales = Math.Pow(10, this.cantidadDecimales);      //Se usara para ajustar la cantidad de decimales.

            List<double> listaNumeroGenerados = new List<double>();         // Crea una lista vacia de numeros generados

            Random random = new Random();
            double test;
            do
            {
                 test = Math.Truncate(random.NextDouble() * ajusteCantidadDecimales) / ajusteCantidadDecimales;//Este truncamiento ajusta a la cantidad de decimales requerida
                listaNumeroGenerados.Add(test);              // agrega el numero generado a la lista


            } while (listaNumeroGenerados.Count < this.cantidadNumerosSolicitados);                    // el ciclo se repite solo 1 periodo.
            return listaNumeroGenerados;


        }


        private void congruencialLinealLibre(int semilla, int cantidadNumeros, int a, int m, int c, int cantidadDecimales, int cantidadIntervalos)
        {
            this.semilla = semilla;
            this.a = a;
            this.m = m;         //calcula m a partir de los numeros a genererar, asegurando que sea 2^g
            this.c = c;
            this.cantidadDecimales = cantidadDecimales;
            this.cantidadIntervalos = cantidadIntervalos;
            this.cantidadNumerosSolicitados = cantidadNumeros;
        }

        //Se asegura que m sea 2^g. Recibe la cantidad de numeros que se desean generar y hace un ciclo de 2^g hasta
        //que el modulo es igual o mayor a la cantidad deseada. En consecuencia el numero generado puede ser
        //mayor al solicitado con el beneficio de que se asegura el cumplimiento de 2^g
        private int obtenerModulo(int cantidadNumeros)
        {
            int g = 1;
            int modulo = 0;
            while (modulo < cantidadNumeros)
            {
                modulo = (int)Math.Pow(2, g);
                g++;
            }
            return modulo;
        }

        // Define un constructor. Setea el generador asegurandose que cada parametro cumple los criterios para que el GENERADOR MULTIPLICATIVO sea optimo.
        private void congruencialMultiplicativo(int semilla, int cantidadNumeros, int k, int g, int cantidadDecimales, int cantidadIntervalos)
        {
            this.semilla = semilla;
            this.a = 3 + 8 * k;
            this.c = 0;                 // c se fija en 0.
            this.m = (long)Math.Pow(2, g);
            this.cantidadDecimales = cantidadDecimales;
            this.cantidadIntervalos = cantidadIntervalos;
            this.cantidadNumerosSolicitados = cantidadNumeros;
        }

        // Define un constructor. Es una variacion del otro constructor. En este caso no tiene en cuenta la cantidad que quiere generar el usuario.
       

        // Define el metodo del generador.  Genera los numeros aleatorios segun a los parametros ya establecidos.
        public List<double> generarNumeros()
        {
            double ajusteCantidadDecimales = Math.Pow(10, this.cantidadDecimales);      //Se usara para ajustar la cantidad de decimales.
             
            long siguienteEntero = semilla;
            double siguienteRND;
            List<double> listaNumeroGenerados = new List<double>();         // Crea una lista vacia de numeros generados
            
            do
            {
                siguienteEntero = (a * siguienteEntero + c) % m;
                siguienteRND = (double)siguienteEntero / (m);      //SE DEJO EN M-1 PARA COMPARAR CON EL PDF RESUELTO. CAMBIAR POR M PARA QUE NO GENERE 1!!!!
                siguienteRND = Math.Truncate(siguienteRND * ajusteCantidadDecimales) / ajusteCantidadDecimales;//Este truncamiento ajusta a la cantidad de decimales requerida
                listaNumeroGenerados.Add(siguienteRND);              // agrega el numero generado a la lista
                

            } while (listaNumeroGenerados.Count < this.cantidadNumerosSolicitados);                    // el ciclo se repite solo 1 periodo.
            return listaNumeroGenerados;
        }
        

        // Cuenta la frecuencia de aparicion en cada intervalo para los numeros generados
        public int[] contarFrecuencias(List<double> listaNumerosGenerados, List<double> listaIntervalos)
        {
           
            int[] arregloFrecuencias = inicializarFrecuencias();                 //Se genera el arreglo de frecuencias
            for (int i = 0; i < listaNumerosGenerados.Count; i++)           //Por cada numero generado
            {
                for (int j = 0; j < listaIntervalos.Count; j++)             //Se fija en cada limite de intervalo
                {
                    if (listaNumerosGenerados[i] < listaIntervalos[j])     //Si es menor al limite del intervalo lo contabiliza en el intervalo correspondiente y pasa al siguiente numero                     
                    {
                        arregloFrecuencias[j]++;
                        break;
                    }
                }
            }
            return arregloFrecuencias;
        }

        // Genera los intervalos correspondientes para la cantidad de intervalos requerida
        public List<double> generarIntervalos()
        {
            List<double> limitesIntervalos = new List<double>();        //lista con los limites superiores de cada intervalo
            double amplitud = (double)1 / this.cantidadIntervalos;
            double limite = 0;

            for (int i = 0; i < this.cantidadIntervalos; i++)            //El ciclo genera el nuevo limite a partir del limite anterior, sumandole la amplitud
            {
                limite += amplitud;
                limite = Math.Round(limite, this.cantidadDecimales);
                limitesIntervalos.Add(limite);

            }

            return limitesIntervalos;
        }

        // Genera un arreglo de tamañlo igual al numero de intervalos y lo inicializa en 0
        private int[] inicializarFrecuencias()
        {
            int[] arregloFrecuencias = new int[this.cantidadIntervalos];
            for (int i = 0; i < arregloFrecuencias.Length; i++)
            {
                arregloFrecuencias[i] = 0;
            }
            return arregloFrecuencias;
        }

        // METODOS TODAVIA NOO DESARROLLADOS PARA ASEGUARARSE QUE C SEA PRIMO RELATIVO DE M.            ¡¡¡¡¡¡¡¡VER!!!!!!!!!!
        private bool EsPrimoRelativo(int numero1, int numero2)
        {
            //calcular el maximo divisor común
            int resto;
            while (numero2 != 0)
            {
                resto = numero1 % numero2;
                numero1 = numero2;
                numero2 = resto;
            }

            //si el el resultado es igual a 1 o a -1, son relativos, si no, no.
            return numero1 == 1 || numero1 == -1;
        }

        private int obtenerSiguientePrimoRelativo(int m)
        {
            int siguientePrimoRelativo = -1;



            return siguientePrimoRelativo;
        }


        public bool pruebaChiCuadrado(int[] arregloFrecuencias)
        {
            bool rechazarHipotesis = true;
            double frecuenciaEsperada = (double) cantidadNumerosSolicitados / this.cantidadIntervalos;
            double estadisiticoPrueba = 0;
            for (int i = 0; i < arregloFrecuencias.Length; i++)
            {
                estadisiticoPrueba += (double)(Math.Pow((arregloFrecuencias[i] - frecuenciaEsperada), 2)) / frecuenciaEsperada;
            }
            this.valorEstadisticoPrueba = estadisiticoPrueba;

            if (estadisiticoPrueba <= obtenerValorCriticoTabulado())
            {
                rechazarHipotesis = false;
            }
            return rechazarHipotesis;
        }

        public double obtenerValorCriticoTabulado()
        {
            double valorCritico = 0;
            int gradosLibertad = this.cantidadIntervalos - 1;
            if (gradosLibertad == 4)
            {
                valorCritico = 9.49;
            }
            if (gradosLibertad == 7)
            {
                valorCritico = 14.1;
            }
            if (gradosLibertad == 9)
            {
                valorCritico = 16.9;
            }
            if (gradosLibertad == 11)
            {
                valorCritico = 19.7;
            }

            return valorCritico;
        }



    }
}
