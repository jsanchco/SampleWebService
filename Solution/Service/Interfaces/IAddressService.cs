namespace Service.Interfaces
{
    #region Using

    using Data.Entities;
    using System.Collections.Generic;

    #endregion

    public interface IAddressService
    {
        Address GetAddress(int id);
        IEnumerable<Address> GetAddresses();
        void InsertAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(int id);
    }
}
