namespace Service.Interfaces
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;

    #endregion

    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
