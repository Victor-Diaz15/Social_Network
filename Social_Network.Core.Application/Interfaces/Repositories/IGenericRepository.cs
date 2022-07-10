using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task<List<Entity>> GetAllAsync();
        Task<List<Entity>> GetAllWithIncludeAsync(List<string> properties);
        Task<Entity> GetByIdAsync(int id);
        Task<Entity> AddAsync(Entity entity);
        Task UpdateAsync(Entity entity, int id);
        Task DeleteAsync(Entity entity);
    }
}
