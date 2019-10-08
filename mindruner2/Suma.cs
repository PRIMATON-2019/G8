using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    public class Suma
    {
        public int contador = 0;
        public int contador1 = 0;
        public int contador2 = 0;
        public int contador3 = 0;
        public int contador4 = 0;
        public string SumaPuntaje(string Npuntaje)
        {
            switch (Convert.ToInt32(Npuntaje))
            {
                case 1:
                    contador = puntaje1(contador1);
                    break;
                case 2:
                    contador = puntaje2(contador2);
                    break;
                case 3:
                    contador = puntaje3(contador3);
                    break;
                case 4:
                    contador = puntaje4(contador4);
                    break;



            }
            return Convert.ToString(contador);
            int puntaje1(int Npuntaje1)
            {
                contador1 = (contador1 + 10);
                return contador1 ;
            }
            int puntaje2(int Npuntaje2)
            {
                contador2 = (contador2 + 10);
                return contador2;
            }
            int puntaje3(int Npuntaje3)
            {
                contador3 = (contador3 + 10);
                return contador3;
            }
            int puntaje4(int Npuntaje4)
            {
                contador4 = (contador4 + 10);
                return contador4;
            }
        }
        public string VisualizarPuntaje(string Npuntaje)
        {
            if (Convert.ToInt32(Npuntaje)==1)
            {
                contador= contador1;
            }

            if (Convert.ToInt32(Npuntaje) == 2)
            {
                contador= contador2;

            }

            if (Convert.ToInt32(Npuntaje) == 3)
            {
                contador = contador3;
            }

            if (Convert.ToInt32(Npuntaje) == 4)
            {
                contador=contador4;
            }

            return Convert.ToString(contador);

        }

    } }
