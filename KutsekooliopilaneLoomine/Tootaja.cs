using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KutsekooliopilaneLoomine.Isik;

namespace KutsekooliopilaneLoomine
{
    class Tootaja : Isik
    {

        protected string asutus;
        protected string amet;
        protected double tootasu;

        public Tootaja(sugu isikSugu, string nimi = "---", int synniAasta = 0,string asutus = "---", string amet = "---", double tootasu = 0) : base(isikSugu, nimi, synniAasta)
        {
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public Tootaja(Tootaja ob) : base(ob)
        {
            this.asutus = ob.asutus;
            this.amet = ob.amet;
            this.tootasu = ob.tootasu;
        }

        public override void print_Info()
        {
            base.print_Info();
            Console.WriteLine("{0,-15} {1,-15} {2,7:f2}", asutus, amet, tootasu);
        }

        public override double arvutaSissetulek(double maksuvaba, double tulemaks)
        {
            double sedaTeEiNae = (tootasu - maksuvaba) * (tulemaks / 100);
            double netopalk = tootasu - sedaTeEiNae;
            return netopalk;
        }

        public override string kooliKoht(string koht)
        {
            //string koht;
            string[] asukohad = { "Sõpruse pst. 182", "Politehnikum" };
            if (asutus == "TTHK")
            {
                koht = asukohad[0];
            }
            else
            {
                koht = asukohad[1];
            }
            return asutus;
        }

        public virtual void Vanus()
        {
            arvutaVanus();
        }


        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
    }
}
