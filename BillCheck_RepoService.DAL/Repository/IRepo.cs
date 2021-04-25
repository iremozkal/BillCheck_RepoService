using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BillCheck_RepoService.DAL.Repository
{
    public interface IRepo<T> where T : class
    {
        T GetById(int Id);
        List<T> GetByAll();
        bool Insert(T Entity);
        bool Update(T Entity);
        bool SoftDelete(T Entity);
        bool HardDelete(T Entity);

        List<T> GetByQuery(Expression<Func<T, bool>> Query);
    }
}
