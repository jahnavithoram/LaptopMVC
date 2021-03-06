using schoolMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace schoolMVC.Data
{
    public interface IBaseRepositry<T>where T : BaseModel2
    {
        Task<IEnumerable<T>> GetAll();
        Task <T> Get(string id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(string id);
       
    }
}
