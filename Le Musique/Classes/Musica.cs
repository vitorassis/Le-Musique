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

        public List<Elemento> Notas {
            get => notas;
        }

        public void Tocar()
        {
            foreach(Elemento e in notas)
            {
                e.Tocar();
            }
        }

        public Musica()
        {
            notas = new List<Elemento>();
        }
    }
}
