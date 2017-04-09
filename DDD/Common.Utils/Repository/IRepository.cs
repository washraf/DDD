namespace Common.Utils.Repository
{
    public interface IRepository<TEntityType> : IReadOnlyRepository<TEntityType>,IWriteOnlyRepository<TEntityType> where TEntityType : class, new()
    {
    }
}