using System.Data.Entity;

namespace BuyCar
{
    public class Context : DbContext
    {
        public Context() : base("name=Model")
        {
            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
            //Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
            //Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }
        public virtual DbSet<Vechile> Vechiles { get; set; }
        public virtual DbSet<CustomerCar> CustomerCars { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

    }
}
