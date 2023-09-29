using System;
namespace Bank
{
    public class Konto
    {

        public Konto(double guthaben)
        {
            lezteKontoNr++;
            kontoNr = lezteKontoNr;

            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Eröffnungsbetrag darf nicht negativ sein.");
            }
            this.guthaben = guthaben;

           
            
        }

        private static int lezteKontoNr = 0;
        private int kontoNr;
        public int KontoNr
        {
            get
            {
                return kontoNr;
            }
        }

        private double guthaben;
        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }


        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
