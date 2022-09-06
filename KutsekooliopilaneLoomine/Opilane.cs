using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KutsekooliopilaneLoomine.Isik;

namespace KutsekooliopilaneLoomine
{
    class Opilane : Isik
    {

        protected string koolinimi;
        protected string klass;
        protected string spetsialiseerumine;

        protected double tootasu;

        public Opilane(sugu isikSugu, string nimi = "---", int synniAasta = 0, string koolinimi = "---", string klass = "---", string spetsialiseerumine = "---", double tootasu = 0) : base(isikSugu, nimi, synniAasta)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;

            this.tootasu = tootasu;
        }

        public Opilane(Opilane ob) : base(ob)
        {
            this.koolinimi = ob.koolinimi;
            this.klass = ob.klass;
            this.spetsialiseerumine = ob.spetsialiseerumine;

            this.tootasu = ob.tootasu;
        }

        public override void print_Info()
        {
            base.print_Info();
            Console.WriteLine("{0,-15} {1,-15} {2,7:f2}", koolinimi, klass, spetsialiseerumine);
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
            if (klass == "TTHK")
            {
                koht = asukohad[0];
            }
            else
            {
                koht = asukohad[1];
            }
            return klass;
        }

        public virtual void Vanus()
        {
            arvutaVanus();
        }

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }

        //---Oma funktsioon-----\

        public void muudaKooliNimi(string uusKooliNimi) { koolinimi = uusKooliNimi; }


        //---Oma funktsioon-----/
    }


}
