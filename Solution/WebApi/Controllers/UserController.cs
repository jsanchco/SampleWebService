namespace WebApi.Controllers
{
    #region Using

    using System.Web.Http;
    using Service.Interfaces;
    using Data.Entities;
    using Repository.Interfaces;
    using Service.Services;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class UserController : ApiController
    {
        private readonly IUserService _userService;

        public UserController(IRepository<User> userRepository, IRepository<Address> addressRepository)
        {
            _userService = new UserService(userRepository, addressRepository);
        }

        [Route("user/all")]
        [HttpGet]
        public List<User> GetUsers()
        {
            return _userService.GetUsers().ToList();
        }

        [Route("user/value")]
        [HttpGet]
        public string Value()
        {
            return "Hola!!!";
        }
    }
}
