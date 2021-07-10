using System;
using System.Collections.Generic;
using System.Text;

namespace project_S2.models
{
    class Medicament
    {
        private int id { get; set; }
        private String nom { get; set; }
        private int quantite { get; set; }

        public Medicament(int id, String nom, int quantite)
        {
            this.id = id;
            this.nom = nom;
            this.quantite = quantite;
        }
       

}
}
