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
        private readonly IUserReferallService _userProfileService;

        public CartonCapsReferralController(ILogger<CartonCapsReferralController> logger, IUserReferallService userProfileService)
        {
            _logger = logger;
            _userProfileService = userProfileService;
        }

        [HttpGet]
        [Route("GetFriendsList")]
        public IActionResult GetFriendList(String currentUser)
        {
            return Ok(_userProfileService.GetUserFriendList("default"));
        }

        [HttpPost]
        [Route("ApplyReferralCredit")]
        public IActionResult ApplyReferralCredit(string referralCode, string newUser)
        {
            return Ok(true);
        }

        [HttpPost]
        [Route("RecordReferralInviteSent")]
        public IActionResult RecordReferralInviteSent(string referralCode, string newUser) {
            return Ok(true);
        }

        [HttpGet]
        [Route("GetReferralLink")]
        public IActionResult GetReferralLink(string referralCode)
        {
            return Ok(_userProfileService.GetReferralLink(referralCode));
        }
    }
}
