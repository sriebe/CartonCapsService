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
        IEnumerable<ReferralTracking> GetUserFriendList(string referralCode);

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
        /// <param name="friendName">The name of the friend</param>
        /// <returns>A boolean value indicating the referral credit was applied</returns>
        public bool ApplyReferralCredit(string referralCode, string friendName);

        /// <summary>
        /// Update 
        /// </summary>
        /// <param name="referralCode">The referralCode</param>
        /// <param name="referralType">The type of referral: Text, Email, Share</param>
        /// <param name="friendName">The name of the invited friend</param>
        /// <param name="friendPhone">The mobile phone number of the invited friend</param>
        /// <param name="friendEmail">The email of the invited friend</param>
        /// <returns>A boolean value indicating if the referral invite was recorded</returns>
        public bool RecordReferralInviteSent(string referralCode, string referralType, string friendName, string friendPhone, string friendEmail);
    }
}