using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    public class Lista
    {
        #region Propiedades 
        private string[,] Jugador = new string[4, 3];
        private int ProximaPosicion = 0;
        private int puntaje1 = 0;
        private int puntaje2 = 0;
        private int puntaje3 = 0;
        private int puntaje4 = 0;
        #region Metodos
        public string[,] Carga(string ParametroJugador1, string ParametroJugador2, string ParametroJugador3, string ParametroJugador4)
        {
            Jugador[ProximaPosicion, 0] = ParametroJugador1;
            Jugador[ProximaPosicion, 1] = Convert.ToString(1);
            Jugador[ProximaPosicion, 2] = Convert.ToString(puntaje1);
            ProximaPosicion++;
            Jugador[ProximaPosicion, 0] = ParametroJugador2;
            Jugador[ProximaPosicion, 1] = Convert.ToString(2);
            Jugador[ProximaPosicion, 2] = Convert.ToString(puntaje2);
            ProximaPosicion++;
            Jugador[ProximaPosicion, 0] = ParametroJugador3;
            Jugador[ProximaPosicion, 1] = Convert.ToString(3);
            Jugador[ProximaPosicion, 2] = Convert.ToString(puntaje3);
            ProximaPosicion++;
            Jugador[ProximaPosicion, 0] = ParametroJugador4;
            Jugador[ProximaPosicion, 1] = Convert.ToString(4);
            Jugador[ProximaPosicion, 2] = Convert.ToString(puntaje4);
            ProximaPosicion++;
            return Jugador;
        }
        public String Mostrar()
        {
            string Respuesta = "";
            Respuesta += Jugador[0, 0] + Jugador[0, 1] + Jugador[0, 2] + "\r\n" + Jugador[1, 0] + Jugador[1, 1] + Jugador[1, 2] + "\r\n" + Jugador[2, 0] + Jugador[2, 1] + Jugador[2, 2] + "\r\n" + Jugador[3, 0] + Jugador[3, 1] + Jugador[3, 2];
            return Respuesta;
        }
        #endregion

    }


}



#endregion
