using BillCheck_RepoService.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DAL.Repository
{
    public class Repository<T> : IRepo<T> where T : class
    {
        private readonly BillCheckContext ctx;  // Let it know which context should derive its tables.
        private readonly DbSet<T> dbset;        // Which table does it want to run in this context.

        public Repository()
        {
            ctx = new BillCheckContext();
            dbset = ctx.Set<T>();               // Any table I send into the repository will be set.
        }

        public T GetById(int Id)
        {
            return dbset.Find(Id);
        }

        public List<T> GetByAll()
        {
            return dbset.ToList();
        }

        public bool Insert(T Entity)
        {
            dbset.Add(Entity);

            if (ctx.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(T Entity)
        {
            dbset.Attach(Entity);
            ctx.Entry(Entity).State = EntityState.Modified;

            if (ctx.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SoftDelete(T Entity)
        {
            dbset.Attach(Entity);
            ctx.Entry(Entity).State = EntityState.Modified;

            if (ctx.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HardDelete(T Entity)
        {
            dbset.Remove(Entity);

            if (ctx.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<T> GetByQuery(System.Linq.Expressions.Expression<Func<T, bool>> Query)
        {
            return dbset.Where(Query).ToList();
        }
    }
}
