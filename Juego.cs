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
            estados.Add(Estados.Abajo);
            estados.Add(Estados.Arriba);
            estados.Add(Estados.Derecha);
            estados.Add(Estados.Izquierda);

            //constructor
        }

        public bool Ocupado { get; set; }

        public int Mostrando { get; set; }

        public Estados estadoSolicitado { get; set; }

        
    }
}
