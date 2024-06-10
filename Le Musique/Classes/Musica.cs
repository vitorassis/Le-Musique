using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Musique.Classes
{
    public class Musica
    {
        private List<Elemento> notas;
        private int andamento;

        public List<Elemento> Notas {
            get => notas;
        }
        public int Andamento { set => andamento = value; }  

        public void Tocar()
        {
            foreach(Elemento e in notas)
            {
                e.Andamento = andamento;
                e.Tocar();
            }
        }

        public Musica()
        {
            notas = new List<Elemento>();
        }
    }
}
