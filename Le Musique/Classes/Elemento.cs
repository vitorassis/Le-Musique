using Le_Musique.Classes.ENums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Musique.Classes
{
    public abstract class Elemento
    {
        private EDuracao duracao;
        public EDuracao Duracao { get => duracao; }

        public Elemento(EDuracao duracao)
        {
            this.duracao = duracao;
        }

        public double DuracaoReal
        {
            get => (double)4 / (int)Duracao * 1000;
        }

        public abstract void Tocar();
    }
}
