using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutsekooliopilaneLoomine
{
    class Kutsekooliõpilane : Isik
    {

        protected string oppeasutus;
        protected string eriala;
        protected string kursus;
        protected double toetus;

        protected double tootasu;

        public Kutsekooliõpilane(sugu isikSugu, string nimi = "---", int synniAasta = 0, string oppeasutus = "---", string eriala = "---", string kursus = "---", double toetus = 0, double tootasu = 0) : base(isikSugu, nimi, synniAasta)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;

            this.tootasu = tootasu;
        }

        public Kutsekooliõpilane(Kutsekooliõpilane ob) : base(ob)
        {
            this.oppeasutus = ob.oppeasutus;
            this.eriala = ob.eriala;
            this.kursus = ob.kursus;
            this.toetus = ob.toetus;

            this.tootasu = ob.tootasu;
        }

        public override void print_Info()
        {
            base.print_Info();
            Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,7:f2}", oppeasutus, eriala, kursus, toetus);
        }

        public override double arvutaSissetulek(double maksuvaba, double tulemaks)
        {
            double sedaTeEiNae = (tootasu - maksuvaba) * (tulemaks / 100);
            double netopalk = tootasu - sedaTeEiNae;
            return netopalk;
        }

        public virtual void Vanus()
        {
            arvutaVanus();
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }

        public override string kooliKoht(string koht)
        {
            //string koht;
            string[] asukohad = { "Sõpruse pst. 182", "Pärnu mnt 57a" };
            if (oppeasutus == "TTHK")
            {
                koht = asukohad[0];
                Console.WriteLine(koht);
            }
            else
            {
                koht = asukohad[1];
                Console.WriteLine(koht);
            }
            return oppeasutus;
        }

    }
}
