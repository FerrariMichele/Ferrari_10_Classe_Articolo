using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari_10_Classe_Articolo
{
    public class Articolo
    {
        private string _prodID;
        private string _report;
        private double _unitPrice;
        public string ProdID
        {
            get { return _prodID; }
            set { _prodID = value; }
        }
        public string Report
        {
            get { return _report; }
            set { _report = value; }
        }
        public double UnitPrice
        { 
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        public Articolo(string prodID, string report, double unitPrice)
        {
            ProdID = prodID;
            Report = report;
            UnitPrice = unitPrice;
        }
        public virtual double Sconta(bool isMember)
        {
            if (isMember)
                return UnitPrice / 100 * 95;
            else
                return UnitPrice;
        }
    }
}
