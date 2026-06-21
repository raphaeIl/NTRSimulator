namespace NTRSimulator.Database.Core
{
    public class Repository<T>(NTRSimulatorDbContext db) : IRepository<T> where T : class
    {
        protected readonly NTRSimulatorDbContext Db = db;

        public virtual T? GetById(long id) => Db.Set<T>().Find(id);

        public virtual void Add(T entity)
        {
            Db.Set<T>().Add(entity);

            this.SaveChanges();
        }

        public virtual void Remove(T entity)
        {
            Db.Set<T>().Remove(entity);

            this.SaveChanges();
        }

        public virtual int SaveChanges() => Db.SaveChanges();
    }
}
