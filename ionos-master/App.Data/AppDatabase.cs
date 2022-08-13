using App.Data.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    class AppDatabase : Disposable, IDatabase
    {
        readonly AppDbContext context = new AppDbContext(null);
        public DbSet<T> GetDbSet<T>() where T : class
        {
            return context.Set<T>();
        }
        public void MarkAsChanged<T>(T entity) where T : class
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        protected override void DisposeCore()
        {
            base.DisposeCore();
            context?.Dispose();
        }
    }
}
