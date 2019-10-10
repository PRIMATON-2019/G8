using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mindruner2
{
    class preguntascine
    {
        private string[,] PYR = new string[20, 5];


        #region Metodos

        public string Preguntas(string NumerodePregunta)
        {
            PYR[0, 0] = "¿Que personaje de Star Wars se convierte en Darth Vader?";
            PYR[1, 0] = "¿Que actor representa a Jack Sparrow en Piratas del Caribe?";
            PYR[2, 0] = "¿Que personaje de los Simpson tiene un bypass?";
            PYR[3, 0] = "¿Que tipo de pez es Nemo?";
            PYR[4, 0] = "¿Que animal es Patricio en la serie Bob Esponja? ";           
            PYR[5, 0] = "¿Cual es la pelicula más taquillera de la historia?";
            PYR[6, 0] = "¿De qué año es la primera entrega de Matrix?";
            PYR[7, 0] = "¿Cómo se llama la primera película del Señor de los Anillos?";
            PYR[8, 0] = "¿De qué compañia es la película Las Cronicas de Narnia: el león, la bruja y el ropero?";
            PYR[9, 0] = "¿Como se llama el burro que acompaña siempre a Shrek?";
            PYR[10, 0] ="¿En la pelicula Titanic: ¿Como se llaman los protagonistas principales?;
            PYR[11, 0] = "¿Cual película argentina ganó un premio Oscar en el 2010?";
            PYR[12, 0] = "¿Cómo se llama el robot alcohólico de la serie 'Futurama'?";
            PYR[13, 0] = "¿Cómo se llama el pájaro símbolo de los Juegos del Hambre?";
            PYR[14, 0] = "¿Cuál es el nombre de la canción de la película 'Titanic'?";
            PYR[15, 0] = "¿Cómo se llamaba el primer gato de Los Simpsons?";
            PYR[16, 0] = "¿Qué quería comerse Alf?";
            PYR[17, 0] = "¿Cómo se llama el ayudante de Iron Man?";
            PYR[18, 0] = "¿Cómo se llamaba el papá de Simba n la película El Rey León?";
            PYR[19, 0] = "¿Quién se convirtió en el mejor amigo de Woody en la película Toy Story?";
        
            



            string pregunta = PYR[Convert.ToInt32(NumerodePregunta) - 1, 0];

            return pregunta;

        }
        public string opc1(string NumerodePregunta)
        {
            PYR[0, 1] = " Yoda";
            PYR[1, 1] = " Orlando Bloom";
            PYR[2, 1] = " El señor Burns";
            PYR[3, 1] = " Pez payaso.";
            PYR[4, 1] = " Delfín";
            PYR[5, 1] = " Titanic";
            PYR[6, 1] = " 2000";
            PYR[7, 1] = " Las dos Torres";
            PYR[8, 1] = " Disney";
            PYR[9, 1] = " Burro";
            PYR[10, 1] = "Jack y Rose ";
            PYR[11, 1] = "El secreto de sus ojos";
            PYR[12, 1] = "Leela";
            PYR[13, 1] = "Sinsajo";
            PYR[14, 1] = "Bad Romance";
            PYR[15, 1] = "Bola de nieve";
            PYR[16, 1] = "Al gato";
            PYR[17, 1] = "Warmachine";
            PYR[18, 1] = "Zazú";
            PYR[19, 1] = "Buzz Lightyear";
     

            string opc1 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 1];
            return opc1;

        }
        public string opc2(string NumerodePregunta)
        {
            PYR[0, 2] = "Kenobi";
            PYR[1, 2] = "Johnny Deep";
            PYR[2, 2] = "Krosty, el payaso";
            PYR[3, 2] = "Pez globo";
            PYR[4, 2] = "Cangrejo";
            PYR[5, 2] = "Avengers: Eng Game";
            PYR[6, 2] = "1999";
            PYR[7, 2] = "El retorno del rey";
            PYR[8, 2] = "Warner Brothers";
            PYR[9, 2] = "Blanco";
            PYR[10, 2] = "Mark y Mary";
            PYR[11, 2] = "Relatos Salvajes";
            PYR[12, 2] = "Bender";
            PYR[13, 2] = "Lechuza";
            PYR[14, 2] = "Killer queen";
            PYR[15, 2] = "Gato";
            PYR[16, 2] = "A Willie";
            PYR[17, 2] = "Jarvis";
            PYR[18, 2] = "Mufasa";
            PYR[19, 2] = "Andy";



            string opc2 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 2];
            return opc2;
        }
        public string opc3(string NumerodePregunta)
        {
            PYR[0, 3] = "Skywalker";
            PYR[1, 3] = "Antonio Banderas";
            PYR[2, 3] = "Moe";
            PYR[3, 3] = "Pez dorado";
            PYR[4, 3] = "Estrella de mar rosa";
            PYR[5, 3] = "Avatar";
            PYR[6, 3] = "2004";
            PYR[7, 3] = "La comunidad del anillo";
            PYR[8, 3] = "Dreamworks";
            PYR[9, 3] = "Donatello";
            PYR[10, 3] = "Robert y Carol";
            PYR[11, 3] = "Pizza, birra y faso";
            PYR[12, 3] = "Zoidberg";
            PYR[13, 3] = "Gale";
            PYR[14, 3] = "My heart will go on";
            PYR[15, 3] = "Nieve";
            PYR[16, 3] = "Las plantas";
            PYR[17, 3] = "Tony";
            PYR[18, 3] = "Scar";
            PYR[19, 3] = "El señor cara de papa";


            string opc3 = PYR[Convert.ToInt32(NumerodePregunta) - 1, 3];
            return opc3;
        }
        public string resultado(string NumerodePregunta)
        {
            PYR[0, 4] = "3";
            PYR[1, 4] = "2";
            PYR[2, 4] = "2";
            PYR[3, 4] = "1";
            PYR[4, 4] = "3";
            PYR[5, 4] = "2";
            PYR[6, 4] = "2";
            PYR[7, 4] = "3";
            PYR[8, 4] = "1";
            PYR[9, 4] = "1";
            PYR[10, 4] = "1";
            PYR[11, 4] = "1";
            PYR[12, 4] = "2";
            PYR[13, 4] = "1";
            PYR[14, 4] = "1";
            PYR[15, 4] = "1";
            PYR[16, 4] = "1";
            PYR[17, 4] = "2";
            PYR[18, 4] = "2";
            PYR[19, 4] = "1";
      

            string resultado = PYR[Convert.ToInt32(NumerodePregunta) - 1, 4];
            return resultado;
        }
        #endregion
    }
}