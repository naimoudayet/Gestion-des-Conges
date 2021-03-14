using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_des_Conges.model;

namespace Gestion_des_Conges.dao
{
    interface IUser
    {
        User login(User user);

        void create(User user);

        void update(User user);

        void delete(int id);

        User readOne(int id);

        List<User> readAll();
    }
}
