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
        private readonly IUserReferallService _userReferralService;

        public CartonCapsReferralController(ILogger<CartonCapsReferralController> logger, IUserReferallService userProfileService)
        {
            _logger = logger;
            _userReferralService = userProfileService;
        }

        [HttpGet]
        [Route("GetFriendsList")]
        public IActionResult GetFriendList(String referralCode)
        {
            return Ok(_userReferralService.GetUserFriendList(referralCode));
        }

        [HttpPost]
        [Route("ApplyReferralCredit")]
        public IActionResult ApplyReferralCredit(string referralCode, Friend friend)
        {
            return Ok(_userReferralService.ApplyReferralCredit(referralCode, friend));
        }

        [HttpPost]
        [Route("RecordReferralInviteSent")]
        public IActionResult RecordReferralInviteSent(string referralCode, string referralType, Friend friend) {
            return Ok(_userReferralService.RecordReferralInviteSent(referralCode, referralType, friend));
        }

        [HttpGet]
        [Route("GetReferralLink")]
        public IActionResult GetReferralLink(string referralCode)
        {
            return Ok(_userReferralService.GetReferralLink(referralCode));
        }
    }
}
