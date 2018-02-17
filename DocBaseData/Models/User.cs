using DocBaseData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocBaseData.Models
{
    public class User : IEntity
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string Login { get; set; }

        public virtual string Password { get; set; }

        public virtual UserStatus Status { get; set; }

        public enum UserStatus
        {
            
            Active = 1,
            Ban = 2,
            Deleted = 3
        }

        public virtual UserRole Role { get; set; }

        public enum UserRole
        {
            Admin = 1,
            User = 2,
            Payed = 3
        }
    }
}
