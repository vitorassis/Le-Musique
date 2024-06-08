using Le_Musique.Classes.ENums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Musique.Classes
{
    public class Pausa : Elemento
    {
        public Pausa(EDuracao duracao) : base(duracao)
        {
        }

        public override void Tocar() {
            Thread.Sleep((int)DuracaoReal);
        }
    }
}
