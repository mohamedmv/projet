using System;
using System.Collections.Generic;
using System.Text;

namespace project_S2.models
{
    class Command
    {
        private int id { get; set; }
        private List<Achat> achats { get; set; }
        private DateTime date { get; set; }
        Command(int id, List<Achat> achats,DateTime date)
        {
            this.date = date;
            this.id = id;
            this.achats = achats;
        }

    }
}
