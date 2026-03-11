using System.Data.Entity;
using WindowsFormsAppAdoNetCRUD;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    internal class DatabaseContext : DbContext // DbContext sınıfı entity framework paketiyle birlikte gelir.
    {
        public virtual DbSet<Category> Categories { get; set; } // dbset tanımlayarak veitabaındaki tabloları sembnolize ediyoruz
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
