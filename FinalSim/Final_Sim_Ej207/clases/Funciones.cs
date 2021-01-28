using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Sim_Ej207.clases
{
    class Funciones
    {
        public double uniforme(double rnd, int a, int b)
        {
            double valor = (rnd * (b - a)) + a;

            return valor;
        }

        public double normal(double rnd1, double rnd2, int media, int desv)
        {
            double coseno = Math.Cos(2 * Math.PI * rnd2);
            double raiz = Math.Sqrt(-2 * Math.Log(rnd1));
            double tiempo = media + (raiz * coseno) * desv;
            return tiempo;
        }

        public double poisson(double rnd, double prom) 
        {
            double a = Math.Log(1-rnd);
            double x = (-1 / prom) * a;
            return x;
        }

        // Calculo la cantidad d vasos que voy a recoger
        public int cantVasosARecoger(double rnd, int vasosRecoger)
        {
            int vasosARecoger = 0;

            if( vasosRecoger > 0)
            {
                if( vasosRecoger > 10)
                {
                    if (rnd >= 0.5)
                    {
                        if (vasosRecoger <= 20)
                        {
                            vasosARecoger = vasosRecoger;
                           // return vasosARecoger;
                        }
                        if (vasosRecoger > 20)
                        {
                            vasosARecoger = 20;
                           // return vasosARecoger;
                        }
                    }
                    else
                    {                      
                            vasosARecoger = 10;
                          //  return vasosARecoger;
                    }
                }
                else
                {
                    vasosARecoger = vasosRecoger;
                    // return vasosARecoger;
                }
                
            }

            return vasosARecoger;
        }

        // Calculo el tiempo que me va a llevar recoger los vasos dependiendo de su cantidad
        public double tiempoRecogerVasos(int vasosARecoger)
        {
            double tiempoEnRecoger = 3;

            if(vasosARecoger > 10)
            {
                tiempoEnRecoger = 5;
            }

            return tiempoEnRecoger;
        }

        // Determinar el menor de los eventos para ver que evento va a seguir en la proxima iteración
        public double menor(double llegada, double finEspera, double finServir, double finLavar, double finRecoger, double finTomar)
        {
            double[] vec = new double[] { llegada, finEspera, finServir, finLavar, finRecoger, finTomar};

            Array.Sort(vec);

            int index = Array.FindIndex(vec, x => x != 0);
            double min = vec[index];

            return min;
        }

        //Determino el evento que sigue en base al minimo calculado anteriormente
        public string DeterminarEventoFinaliza(String[] eventos, double minimo, double llegada, double finEspera, double finServir, double finLavar, double finRecoger, double finTomar)
        {
            string eventoFinaliza = "";

            if (llegada == minimo)
            {
                eventoFinaliza = eventos[0];
                return eventoFinaliza;
            }
            if (finEspera == minimo)
            {
                eventoFinaliza = eventos[5];
                return eventoFinaliza;
            }
            if (finServir == minimo)
            {
                eventoFinaliza = eventos[1];
                return eventoFinaliza;
            }
            if (finLavar == minimo)
            {
                eventoFinaliza = eventos[2];
                return eventoFinaliza;
            }
            if (finRecoger == minimo)
            {
                eventoFinaliza = eventos[3];
                return eventoFinaliza;
            }
            if (finTomar == minimo)
            {
                eventoFinaliza = eventos[4];
                return eventoFinaliza;
            }

            return eventoFinaliza;
        }
    } 
}
