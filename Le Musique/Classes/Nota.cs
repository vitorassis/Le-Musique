using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Le_Musique.Classes.ENums;

namespace Le_Musique.Classes
{
    public class Nota : Elemento
    {
        private ENota tom;
        private int oitava;

        public ENota Tom
        {
            get => tom;
        }


        public int Oitava { get => oitava;}

        public Nota(ENota tom, int oitava, EDuracao duracao) : base(duracao)
        {
            this.tom = tom;
            this.oitava = oitava;
        }

        public override void Tocar()
        {
            double freq = ((double)((int) tom))/1000000 * Math.Pow(2, oitava);

            Console.WriteLine(tom.ToString() + " " + freq.ToString());
            Console.Beep((int)freq, (int)DuracaoReal);

        }
    }
}
