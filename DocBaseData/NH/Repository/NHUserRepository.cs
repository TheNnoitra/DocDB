using DocBaseData.Models;
using DocBaseData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocBaseData.NH.Repository
{
    public class NHUserRepository : NHBaseRepository<User>, IUserRepository
    {
        public bool Check(string login, string password)
        {
            var session = Helper.GetCurrentSession();

            return session
                .QueryOver<User>()
                .And(u => u.Login == login && u.Password == password)
                .RowCount() > 0;

        }

        public User GetByName(string login)
        {
            var session = Helper.GetCurrentSession();

            return session
                .QueryOver<User>()
                .And(u => u.Login == login)
                .SingleOrDefault();

        }
    }
}
