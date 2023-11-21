using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_10_Classe_Articolo
{
    public class ArticoloAlimentareFresco : ArticoloAlimentare
    {

        public ArticoloAlimentareFresco (string prodID, string report, double unitPrice, string expYear, int daysTillExp) : base(prodID, report, unitPrice, expYear)
        {
            daysTillExp = 
        }
        public override double Sconta(bool isMember)
        {
            double finalPrice = UnitPrice;
            if (isMember)
            {
                finalPrice = finalPrice / 100 * 95;
            }
            if (ExpYear == DateTime.Now.Year.ToString())
            {
                finalPrice = finalPrice / 100 * 80;
            }
            return finalPrice;
        }
    }
}
