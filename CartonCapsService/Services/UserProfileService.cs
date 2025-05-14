using CartonCapsService.Models;

namespace CartonCapsService.Services
{

    public class UserProfileService : IUserReferallService
    {
        public IEnumerable<Person> GetUserFriendList(String user)
        {
            // TODO: Call Repository class to pull data from database
            List<Person> friends = new List<Person>();
            friends.Add(new Person(1, "Bob", "Ross"));
            friends.Add(new Person(2, "Frank", "Zappa"));
            return friends;
        }

        public string GetReferralLink(string referralCode)
        {
            // TODO: Call third-party to build the referral URL with referralCode
            return "https://deferredReferralSerice.co/dynamic_secret/" + referralCode;
        }

    }

}
