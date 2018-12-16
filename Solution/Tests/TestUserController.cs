namespace Tests
{
    #region Using

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Repository;
    using WebApi.Controllers;
    using Data.Entities;
    using System.Linq;

    #endregion

    [TestClass]
    public class TestUserController
    {
        [TestMethod]
        public void GetUsers()
        {
            var controller = new UserController(new Repository<User>(), new Repository<Address>());
            var users = controller.GetUsers().ToList();

            Assert.IsFalse(users.Count == 0);
        }
    }
}
