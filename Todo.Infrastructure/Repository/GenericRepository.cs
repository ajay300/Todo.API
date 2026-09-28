using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Todo.Infrastructure.Persistence.Entities;

namespace Todo.Infrastructure.Repository
{
    public class GenericRepository<TDomain, TEntity> : IGenericRepository<TDomain>
        where TDomain : class
        where TEntity : class
    {

        private readonly TodoAppDbcontext _context;

        public GenericRepository(TodoAppDbcontext context)
        {
            _context = context;
        }




        public async Task<TDomain> GetByIDAsync(Guid id)
        {

            // Fetch Id from database using id


            var entity = await _context.Set<TEntity>().FindAsync(id); //Id should be primary key otherwise it wont work!


            throw new NotImplementedException();
        }

        public Task<IEnumerable<TDomain>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(TDomain domain)
        {
            throw new NotImplementedException();
        }

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}