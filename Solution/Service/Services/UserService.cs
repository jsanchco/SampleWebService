namespace Service.Services
{
    #region Using

    using System.Collections.Generic;
    using Data.Entities;
    using Repository.Interfaces;
    using Interfaces;

    #endregion

    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Address> _addressRepository;

        public UserService(IRepository<User> userRepository, IRepository<Address> addressRepository)
        {
            _userRepository = userRepository;
            _addressRepository = addressRepository;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUser(int id)
        {
            return _userRepository.Get(id);
        }

        public void InsertUser(User user)
        {
            _userRepository.Insert(user);
        }
        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            var address = _addressRepository.Get(id);
            _addressRepository.Remove(address);

            var user = GetUser(id);
            _userRepository.Remove(user);
            _userRepository.SaveChanges();
        }
    }
}
