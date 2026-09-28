namespace Todo.Infrastructure.Repository
{
    public interface IGenericRepository<TDomain>
        where TDomain : class
    {
        Task<TDomain> GetByIDAsync(Guid id);

        Task<IEnumerable<TDomain>> GetAllAsync();

        Task AddAsync(TDomain domain);

        Task<int> CommitAsync();
    }
}