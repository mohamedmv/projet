using System;
using System.Collections.Generic;
using System.Text;

namespace project_S2.models
{
    class Vente
    {
        private int id { get; set; }
        private int quantite { get; set; }
        private Medicament medi { get; set; }

        public Vente(int id,int quantite,Medicament medi)
        {
            this.id = id;
            this.quantite = quantite;
            this.medi = medi;
        }
    }
}
