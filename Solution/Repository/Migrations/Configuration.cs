namespace Repository.Migrations
{
    #region Using

    using System;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    internal sealed class Configuration : DbMigrationsConfiguration<Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(Context context)
        {
            var users = new List<User>
            {
                new User { Age = 46, BirthDate = new DateTime(1972, 8, 1), Name = "Jes�s", Surname = "S�nchez" }
            };
            users.ForEach(p => context.Users.AddOrUpdate(x => x.Id, p));
            context.SaveChanges();

            var addresses = new List<Address>
            {
                new Address { AddedDate = null, ModifiedDate = null, UserId = 1, Street = "Avda. de las Suertes", Number = 55}
            };
            addresses.ForEach(p => context.Addresses.AddOrUpdate(x => x.Id, p));
            context.SaveChanges();
        }
    }
}