namespace Repository
{
    #region Using

    using System.Data.Entity;
    using Data.Entities;

    #endregion

    public class Context : DbContext
    {
        #region Members

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        #endregion

        #region Constructor

        public Context()
        {

        }

        public Context(string connectionString) : base(connectionString)
        {

        }

        #endregion
    }
}
