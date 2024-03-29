﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindruner2
{
    public class Lista
    {
        
        #region Propiedades 
        public string[,] Jugador = new string[4, 2];
        

      


        #region Metodos
        public string[,] quiengana(string j1, string j2, string j3, string j4, string p1, string p2, string p3, string p4)
        {
            Jugador[0, 0] = j1;
            Jugador[0, 1] = p1;
            Jugador[1, 0] = j2;
            Jugador[1, 1] = p2;
            Jugador[2, 0] = j3;
            Jugador[2, 1] = p3;
            Jugador[3, 0] = j4;
            Jugador[3, 1] = p4;
            this.Jugador = ordenar(Jugador);
            return Jugador;
        }
        public string[,] ordenar (string[,] JugadorDestino)
        {
            string TempJugador = "";
            string TempPuntage = "";
            for (int j = 0; j < JugadorDestino.Length-1; j++)
            {
               
                for (int i = 0; i < JugadorDestino.Length-1; i++)
                {
                    try
                    {
                        if (String.Compare(JugadorDestino[i, 1], JugadorDestino[(i + 1), 1]) == 1)
                        {
                            TempJugador = JugadorDestino[i, 0];
                            TempPuntage = JugadorDestino[i, 1];

                            JugadorDestino[i, 0] = JugadorDestino[(i + 1), 0];
                            JugadorDestino[i, 1] = JugadorDestino[(i + 1), 1];

                            JugadorDestino[(i + 1), 0] = TempJugador;
                            JugadorDestino[(i + 1), 1] = TempPuntage;


                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Finalizo la revision de la lista");
                    }

                   

                  

                }

            }
            return JugadorDestino;
        }
        #endregion

    }


}



#endregion
