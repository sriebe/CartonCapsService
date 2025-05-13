using CartonCapsService.Models;
using Microsoft.AspNetCore.Mvc;

using CartonCapsService.Services;

namespace CartonCapsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartonCapsReferralController : ControllerBase
    {

        private readonly ILogger<CartonCapsReferralController> _logger;
        private readonly IUserProfileService _userProfileService;

        public CartonCapsReferralController(ILogger<CartonCapsReferralController> logger, IUserProfileService userProfileService)
        {
            _logger = logger;
            _userProfileService = userProfileService;
        }

        [HttpGet]
        [Route("GetFriendsList")]
        public IEnumerable<Person> GetFriendList(String currentUser)
        {
            return _userProfileService.GetUserFriendList("default");
        }
    }
}
