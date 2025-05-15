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

        public bool ApplyReferralCredit(string referralCode, Friend friend)
        {
            // TODO: Add database support
            Console.WriteLine("Apply credit to Referral Code {0} with credit for {1}", referralCode, friend.FirstName);
            return true;
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
