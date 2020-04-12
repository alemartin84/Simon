using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    class Juego
    {

        public List<Estados> estados = new List<Estados>() ;
        public Juego()
        {
            // LE CARGO ALGO INICIAL PARA PODER PROBAR LA LISTA -- SACAR !!!
            /*
            estados.Add(Estados.Abajo);
            estados.Add(Estados.Arriba);
            estados.Add(Estados.Derecha);
            estados.Add(Estados.Izquierda);
            */
            //constructor
        }

        public bool Ocupado { get; set; }

        public int Mostrando { get; set; }

        public int posActual { get; set; }

        public Estados estadoSolicitado { get; set; }

        public void Añadir()
        {
            Array values = Enum.GetValues(typeof(Estados));
            Random random = new Random();
            Estados randomBar = (Estados)values.GetValue(random.Next(values.Length));

            estados.Add(randomBar);
            posActual = 0; //<esta bien esto?
            Mostrando = 0;
            Ocupado = true;
        }

        public void Reiniciar()
        {
            estados.Clear();
            Ocupado = false;
            Mostrando = 0;
            posActual = 0;
        }

        
    }
}
