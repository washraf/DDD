namespace Common.Utils.Repository
{
    public interface IWriteOnlyRepository<TEntityType> where TEntityType : class, new()
    {
        void Insert(TEntityType entity);
        void Update(TEntityType entity);
        void Delete(TEntityType entity);
    }
}