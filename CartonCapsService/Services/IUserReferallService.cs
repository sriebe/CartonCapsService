using CartonCapsService.Models;

namespace CartonCapsService.Services
{

    public interface IUserReferallService
    {
        /// <summary>
        /// Retrieves a list of friends for a user
        /// </summary>
        /// <param name="user">The user id used for retrieving friends list</param>
        IEnumerable<Person> GetUserFriendList(string user);

        /// <summary>
        /// Generate a referral link using the supplied referralCode
        /// </summary>
        /// <param name="referralCode">The referralCode</param>
        string GetReferralLink(string referralCode);
    }
}