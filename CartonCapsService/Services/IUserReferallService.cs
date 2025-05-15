using CartonCapsService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CartonCapsService.Services
{

    public interface IUserReferallService
    {
        /// <summary>
        /// Retrieves a list of friends for a user
        /// </summary>
        /// <param name="referralCode">The referralCode used for retrieving friends list</param>
        /// <returns>A lit of Person objects which are friends of the user</returns>
        Task<IEnumerable<ReferralTracking>> GetUserFriendList(String referralCode);

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
        /// <param name="friend">A instance of Friend after they have created a new account</param>
        /// <returns>A boolean value indicating the referral credit was applied</returns>
        public bool ApplyReferralCredit(string referralCode, Friend friend);

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="referralCode">The referralCode</param>
        /// <param name="referralType">The type of referral: Text, Email, Share</param>
        /// <param name="friend">The friend who is the recipient of the invite</param>
        /// <returns>A boolean value indicating if the referral invite was recorded</returns>
        public bool RecordReferralInviteSent(string referralCode, string referralType, Friend friend);
    }
}