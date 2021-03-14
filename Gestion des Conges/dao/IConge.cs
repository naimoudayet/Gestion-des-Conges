using Gestion_des_Conges.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_Conges.dao
{
    interface IConge
    {
        void create(Conge conge);

        void update(Conge conge);

        void delete(int id);

        int solde(int id);

        List<Conge> readAll();

        List<Conge> readAllById(int id);

        Conge readOne(int id);
    }
}
