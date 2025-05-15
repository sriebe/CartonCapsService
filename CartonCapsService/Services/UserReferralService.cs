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
            // TODO: Add database support
            var friends = new List<ReferralTracking>();

            // Select From ReferralTracking Where ReferralCode = referralCode;
            using var db = new ReferralTrackingContext();

            var result = await db.ReferralTracking.Where(p => p.ReferralCode.Equals(referralCode)).ToListAsync();

            //var friend1 = new ReferralTracking();
            //friend1.ReferralCode = referralCode;
            //friend1.ReferralType = "Text";
            //friend1.RefereeFirstName = "Clark";
            //friend1.RefereeLastName = "Kent";
            //friend1.RefereePhone = "12223334444";
            //friend1.ReferralStatus = "Invite Sent"; // TODO: Convert this to an enum or a constant
            //friends.Add(friend1);

            //var friend2 = new ReferralTracking();
            //friend2.ReferralCode = referralCode;
            //friend2.ReferralType = "Text";
            //friend2.RefereeFirstName = "Lois";
            //friend2.RefereeLastName = "Lane";
            //friend2.RefereePhone = "12223334445";
            //friend2.ReferralStatus = "Invite Sent"; // TODO: Convert this to an enum or a constant
            //friends.Add(friend2);

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

        public bool RecordReferralInviteSent(string referralCode, string referralType, Friend friend)
        {
            // TODO: Add database support

            // Insert Into ReferralTracking (ReferralCode, ReferralType, ReferralStatus, RefreenFirstName, RefereeLastName, RefereePhone, RefereeEmail)
            // Values (referralCode, referralType, 'Invite Sent', RefereeFirstName, RefereeLastName, RefereePhone, RefereeEmail);

            var tracking = new ReferralTracking();
            tracking.ReferralCode = referralCode;
            tracking.ReferralType = referralType;
            tracking.ReferralStatus = "Invite Sent";
            tracking.RefereeFirstName = friend.FirstName;
            tracking.RefereeLastName = friend.LastName;
            tracking.RefereePhone = friend.Phone;
            tracking.RefereeEmail = friend.Email;

            // _trackingContext.ReferralTracking.Add(tracking);
            // await _trackingContext.SaveChangesAsync();

            Console.WriteLine("Update Referral Tracking with invite sent to {0} from Referral Code {1}", tracking.RefereeFirstName, tracking.ReferralCode);
            return true;
        }

    }

}
