using CartonCapsService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CartonCapsService.Services
{

    public interface IUserReferallService
    {
        /// <summary>
        /// Retrieves a list of friends for a user
        /// </summary>
        /// <param name="user">The user id used for retrieving friends list</param>
        /// <returns>A lit of Person objects which are friends of the user</returns>
        IEnumerable<Person> GetUserFriendList(string user);

        /// <summary>
        /// Generate a referral link using the supplied referralCode
        /// </summary>
        /// <param name="referralCode">The referralCode</param>
        /// <returns>A string representation of the referral link for the supplied referralCode</returns>
        string GetReferralLink(string referralCode);

        /// <summary>
        /// Apply credit to the user for the referral
        /// </summary>
        /// <param name="referralCode">The referralCode</param>
        /// <param name="newUser">The referralCode</param>
        /// <returns>A boolean value indicating the referral credit was applied</returns>
        public bool ApplyReferralCredit(string referralCode, string newUser);

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="referralCode">The referralCode</param>
        /// <param name="newUser">The referralCode</param>
        /// <returns>A boolean value indicating if the referral invite was recorded</returns>
        public bool RecordReferralInviteSent(string referralCode, string newUser);
    }
}