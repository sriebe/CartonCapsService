using CartonCapsService.Models;

namespace CartonCapsService.Services
{

    public class UserProfileService : IUserReferallService
    {
        public IEnumerable<Person> GetUserFriendList(String user)
        {
            // TODO: Call Repository layer to pull data from database
            var friends = new List<Person>();
            friends.Add(new Person(1, "Bob", "Ross"));
            friends.Add(new Person(2, "Frank", "Zappa"));
            return friends;
        }

        public string GetReferralLink(string referralCode)
        {
            // TODO: Call third-party to build the referral URL with referralCode
            return "https://deferredReferralSerice.co/dynamic_secret/" + referralCode;
        }

        public bool ApplyReferralCredit(string referralCode, string newUser)
        {
            // TODO: Apply credit using Repository layer to update database
            return true;
        }

        public bool RecordReferralInviteSent(string referralCode, string newUser)
        {
            // TODO: Call Repsiotry layer to Update datebase with new invite for referralCode
            return true;
        }

    }

}
