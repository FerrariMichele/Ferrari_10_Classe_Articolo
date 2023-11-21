using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_10_Classe_Articolo
{
    public class ArticoloAlimentare : Articolo
    {
        private string _expYear;
        public string ExpYear
        {
            get { return _expYear; }
            set { _expYear = value; }
        }
        public ArticoloAlimentare (string prodID, string report, double unitPrice, string expYear) : base(prodID, report, unitPrice)
        {
            ExpYear = expYear;
        }
        public override double Sconta(bool isMember)
        {
            double finalPrice = UnitPrice;
            if (isMember)
            {
                finalPrice = finalPrice / 100 * (95);
            }
            if (ExpYear == DateTime.Now.Year.ToString())
            {
                finalPrice = finalPrice / 100 * (80);
            }
            return finalPrice;
        }
    }
}
