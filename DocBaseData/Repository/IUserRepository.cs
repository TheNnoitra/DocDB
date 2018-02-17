using DocBaseData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocBaseData.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        /// <summary>
        /// Проверка: есть ли в базе такой пользователь
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        bool Check(string login, string password);


        /// <summary>
        /// Загрузить пользователя по имени
        /// </summary>
        /// <param name="login">Имя пользователя</param>
        /// <returns></returns>
        User GetByName(string login);
    }
}
