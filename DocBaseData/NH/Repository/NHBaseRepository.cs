﻿using DocBaseData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocBaseData.NH.Repository
{
    public class NHBaseRepository<T> : IBaseRepository<T>
       where T : class, IEntity
    {
        public void Delete(long id)
        {
            var item = Find(id);

            if (item != null)
            {
                var session = Helper.GetCurrentSession();
                try
                {
                    using (var transaction = session.BeginTransaction())
                    {
                        session.Delete(item);
                        transaction.Commit();
                    }
                }
                finally
                {
                    Helper.CloseSession();
                }
            }
        }

        public T Find(long id)
        {
            var session = Helper.GetCurrentSession();

            return session.Get<T>(id);
            // item = session.Load<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            using (var session = Helper.GetCurrentSession())
            {
                return session.CreateCriteria<T>().List<T>();
            }
        }

        public IEnumerable<T> GetAll(string condition)
        {
            return GetAll();
        }

        public void Save(T item)
        {
            var session = Helper.GetCurrentSession();
            try
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(item);
                    transaction.Commit();
                }
            }
            finally
            {
                Helper.CloseSession();
            }
        }
    }
}
