namespace TestConsole
{
    #region Using

    using System;
    using System.Linq;
    using Data.Entities;
    using Repository;
    using Service.Services;

    #endregion

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*         Process Test Repository         *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("");
            Console.WriteLine("Press any to start ...");
            Console.ReadLine();

            //ModifyAddress();
            DeleteAddress();

            var userService = new UserService(new Repository<User>(), new Repository<Address>());
            var users = userService.GetUsers().ToList();

            //Console.WriteLine("");
            //Console.WriteLine($"Number users: {users.Count}");

            //var addressService = new AddressService(new Repository<Address>());
            //var address = addressService.GetAddress(1);
            //Console.WriteLine($"Address[1]: {address.Street}");

            Console.WriteLine("");
            Console.WriteLine("Press any to exit ...");
            Console.ReadLine();
        }

        public static void AddAddress(int userId)
        {
            Console.WriteLine("");
            Console.WriteLine("Add address ...");
            var addressService = new AddressService(new Repository<Address>());
            addressService.InsertAddress(new Address { Street = "Calle Nueva", Number = 10, UserId = userId});
            Console.WriteLine("Add address [OK]");
        }

        public static void ModifyAddress()
        {
            Console.WriteLine("");
            Console.WriteLine("Modify address ...");
            var userService = new UserService(new Repository<User>(), new Repository<Address>());
            var user = userService.GetUser(1);
            user.Addresses.ToList()[1].Number = 20;
            userService.UpdateUser(user);
            Console.WriteLine("Modify address [OK]");
        }

        public static void DeleteAddress()
        {
            Console.WriteLine("");
            Console.WriteLine("Delete address ...");
            var userService = new UserService(new Repository<User>(), new Repository<Address>());
            var user = userService.GetUser(1);
            var address = new AddressService(new Repository<Address>()).GetAddress(3);
            var result = user.Addresses.Remove(address);
            result = user.Addresses.Remove(user.Addresses.ElementAt(2));
            //var list = user.Addresses.ToList();
            //list.RemoveAt(2);
            //var addressService = new AddressService(new Repository<Address>());
            //user.Addresses.Remove(addressService.GetAddress(3));
            userService.UpdateUser(user);
            Console.WriteLine("Modify address [OK]");
        }

        public static void AddUser()
        {
            new User {Age = 46, BirthDate = new DateTime(1972, 8, 1), Name = "Jesús", Surname = "Sánchez"};
        }
    }
}
