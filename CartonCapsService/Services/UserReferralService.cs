using CartonCapsService.Models;

namespace CartonCapsService.Services
{

    public class UserReferralService : IUserReferallService
    {
        public IEnumerable<ReferralTracking> GetUserFriendList(String referralCode)
        {
            // TODO: Add database support
            var friends = new List<ReferralTracking>();

            var friend1 = new ReferralTracking();
            friend1.ReferralCode = referralCode;
            friend1.ReferralType = "Text";
            friend1.RefereeName = "Clark Kent";
            friend1.RefereePhone = "12223334444";
            friend1.ReferralStatus = "Invite Sent"; // TODO: Convert this to an enum or a constant
            friends.Add(friend1);

            var friend2 = new ReferralTracking();
            friend2.ReferralCode = referralCode;
            friend2.ReferralType = "Text";
            friend2.RefereeName = "Lois Lane";
            friend2.RefereePhone = "12223334445";
            friend2.ReferralStatus = "Invite Sent"; // TODO: Convert this to an enum or a constant
            friends.Add(friend2);

            return friends;
        }

        public string GetReferralLink(string referralCode)
        {
            // TODO: Call third-party to build the referral URL with referralCode
            return "https://url/dynamic_part/" + referralCode;
        }

        public bool ApplyReferralCredit(string referralCode, string friendName)
        {
            // TODO: Add database support
            // TODO: Creata a Friend object to hold phone and email and add logic to determine what method was used
            Console.WriteLine("Apply credit to Referral Code {0} with credit for {1}", referralCode, friendName);
            return true;
        }

        public bool RecordReferralInviteSent(string referralCode, string referralType, string friendName, string friendPhone, string friendEmail)
        {
            // TODO: Add database support
            // TODO: Create a Friend object to hold all friend attributes
            Console.WriteLine("Update Referral Tracking with invite sent to {0} from Referral Code {1}", friendName, referralCode);
            return true;
        }

    }

}
