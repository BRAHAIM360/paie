using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Formulee
    {
        public int id_formul;
        public string equoition;
        public double Nombre ;
        public double Base;
        public double Taux;
        public double Montant;
        public Formulee() { }
        public void calculé()
        {
            if (equoition.StartsWith("Nombre x Base"))
            {
                Montant = Nombre * Base;
            }
            else if (equoition.StartsWith("Nombre x Taux"))
            {
                Montant = Nombre * Taux;
            }
            else if (equoition.StartsWith("Nombre x Base x Taux"))
            {
                Montant = Nombre * Base * Taux;
            }
            else if (equoition.StartsWith("Base x taux"))
            {
                Montant = Base * Taux;
            }
            else if (equoition.StartsWith("Nombre / Base"))
            {
                Montant = Nombre / Base;
            }
            else if (equoition.StartsWith("Nombre / Taux"))
            {
                Montant = Nombre / Taux;
            }
            else if (equoition.StartsWith("Nombre x Base / Taux"))
            {
                Montant =(Nombre * Base )/ Taux;
            }
            else if (equoition.StartsWith("Nombre / Base x Taux"))
            {
                Montant = Nombre / Base * Taux;
            }
            else if (equoition.StartsWith("Taux / Base"))
            {
                Montant = Taux / Base;
            }

           
        }

    }
}
