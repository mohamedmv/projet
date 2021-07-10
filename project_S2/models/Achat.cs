using System;
using System.Collections.Generic;
using System.Text;

namespace project_S2.models
{
    class Achat
    {
        private int id { get; set; }
        private Medicament medi { get; set; }
        private int quantite {get; set;}

        Achat(int id,int quantite,Medicament medi)
        {
            this.id = id;
            this.quantite = quantite;
            this.medi = medi;
        }
    }
}
