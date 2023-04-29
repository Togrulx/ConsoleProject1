using System;
using ConsoleProject.Core.Models.Base;

namespace ConsoleProject.Core.Repository
{
    public interface IWritterRepository<T> where T : BaseModel
    {
        public Task AddAsync(T model);
        public Task<T> GetAsync(Func<T, bool> expression);
        public Task<List<T>> GetAllAsync();
        public Task RemoveAsync(T model);
    }
}

