using App.Data.Infrastructure;

namespace App.Data
{
    public class AppDatabaseFactory : IDatabaseFactory
    {
        public IDatabase Create()
        {
            return new AppDatabase();
        }
    }
}
