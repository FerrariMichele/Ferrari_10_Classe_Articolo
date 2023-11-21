using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_10_Classe_Articolo
{
    public class ArticoloNonAlimentare : Articolo
    {
        private string _mainComponent;
        private bool _isRecyclable;
        public string MainComponent
        {
            get { return _mainComponent; }
            set { _mainComponent = value; }
        }
        public bool IsRecyclable
        {
            get { return _isRecyclable; }
            set { _isRecyclable = value;}
        }
        public ArticoloNonAlimentare (string prodID, string report, double unitPrice, string mainComponent, bool isRecyclable) : base(prodID, report, unitPrice)
        {
            MainComponent = mainComponent;
            IsRecyclable = isRecyclable;
        }
        public override double Sconta(bool isMember)
        {
            double finalPrice = UnitPrice;
            if (isMember)
            {
                finalPrice = finalPrice / 100 * 95;
            }
            if (IsRecyclable)
            {
                finalPrice = finalPrice / 100 * 90;
            }
            return finalPrice;
        }
    }
}
