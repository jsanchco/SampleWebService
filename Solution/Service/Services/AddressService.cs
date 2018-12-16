namespace Service.Services
{
    #region Using

    using Data.Entities;
    using Interfaces;
    using Repository.Interfaces;
    using System.Collections.Generic;

    #endregion

    public class AddressService : IAddressService
    {
        private readonly IRepository<Address> _addressRepository;

        public AddressService(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }
        public Address GetAddress(int id)
        {
            return _addressRepository.Get(id);
        }

        public IEnumerable<Address> GetAddresses()
        {
            return _addressRepository.GetAll();
        }

        public void InsertAddress(Address address)
        {
            _addressRepository.Insert(address);
        }

        public void UpdateAddress(Address address)
        {
            _addressRepository.Update(address);
        }

        public void DeleteAddress(int id)
        {
            var address = GetAddress(id);
            _addressRepository.Remove(address);
            _addressRepository.SaveChanges();
        }
    }
}
