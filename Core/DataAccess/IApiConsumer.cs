using Core.Entities;
using Core.Utilities.Results;

namespace Core.DataAccess
{
    public interface IApiConsumer<T>
        where T: class, IEntity, new()
    {
        Uri BaseAddress { get; set; }

        Task<IResult?> Add(T entity);
        Task<IResult?> Update(T entity);
        Task<IResult?> Delete(int entityId);
        Task<IDataResult<T>?> Get(int entityId);
        Task<IDataResult<T>?> GetWithDetails(int entityId);
        Task<IDataResult<IEnumerable<T>>?> GetAll();
        Task<IDataResult<IEnumerable<T>>?> GetAllWithDetails();
    }
}
