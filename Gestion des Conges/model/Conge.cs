using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_Conges.model
{
    class Conge
    {

        public int ID { set; get; }

        public User User { set; get; }

        public int Nbr_Jours { set; get; }

        public string Date_Debut{ set; get; }

        public string Date_Fin{ set; get; }
         
        public string Adresse { set; get; }

        public string Num_Tel { set; get; }

        public string Date_Demande { set; get; }

        public string Etat { set; get; }
    }
}
