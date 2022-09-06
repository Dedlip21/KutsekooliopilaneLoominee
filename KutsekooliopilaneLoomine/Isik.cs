using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutsekooliopilaneLoomine
{
    abstract class Isik
    {
        protected string nimi;
        protected int synniAasta;
        public enum sugu { mehe, naine };
        protected sugu isikSugu;


        public Isik(sugu isikSugu, string nimi="---", int synniAasta = 0)
        {
            this.nimi = nimi;
            this.synniAasta = synniAasta;
            this.isikSugu = isikSugu;

        }

        public Isik(Isik ob)
        {
            this.nimi = ob.nimi;
            this.synniAasta = ob.synniAasta;
            this.isikSugu = ob.isikSugu;
        }

        public virtual void print_Info()
        {
            Console.WriteLine("{0,-10} {1} {2,4}", nimi, isikSugu, synniAasta);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synniAasta;
            Console.WriteLine(vanus + " aastat vana.");
            return vanus;
        }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);

        public abstract string kooliKoht(string koht);

        /*public int arvutaSynnipaev()
        {
            int arvuta = kuu - DateTime.Now.Month;
            Console.WriteLine(arvuta + " aastat vana.");
            return arvuta;
        }*/

    }
}
