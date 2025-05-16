using System.Linq;
using CartonCapsService.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CartonCapsService.Services
{

    public class UserReferralService : IUserReferallService
    {
        public async Task<IEnumerable<ReferralTracking>> GetUserFriendList(String referralCode)
        {
            var friends = new List<ReferralTracking>();

            using var db = new ReferralTrackingContext();

            var result = await db.ReferralTracking.Where(p => p.ReferralCode.Equals(referralCode)).ToListAsync();

            return result;
        }

        public string GetReferralLink(string referralCode)
        {
            // TODO: Call third-party to build the referral URL with referralCode
            return "https://url/dynamic_part/" + referralCode;
        }

        /*
         * This method will be called once a user successfully installs the App from a referral link.
         * 
         * The deferred deep link service will supply the referral code to the registration process, which will then
         * call this endpoint to apply the credit within the existing system and update the Referral Tracking table.
         * 
         * The assumption is this will implemented after this is integrated with the existing system.
         */
        public bool ApplyReferralCredit(string referralCode, Friend friend)
        {
            // TODO: Add database support
            Console.WriteLine("Apply credit will be part of a future release.");
            return false;
        }

        public async Task<bool> RecordReferralInviteSent(string referralCode, string referralType, Friend friend)
        {

            var tracking = new ReferralTracking();
            tracking.ReferralCode = referralCode;
            tracking.ReferralType = referralType;
            tracking.ReferralStatus = "Invite Sent";
            tracking.RefereeFirstName = friend.FirstName;
            tracking.RefereeLastName = friend.LastName;
            tracking.RefereePhone = friend.Phone;
            tracking.RefereeEmail = friend.Email;

            using var db = new ReferralTrackingContext();
            db.ReferralTracking.Add(tracking);
            var rowsInserted = await db.SaveChangesAsync();

            if (rowsInserted == 0)
            {
                return false;
            }

            return true;
        }

    }

}
