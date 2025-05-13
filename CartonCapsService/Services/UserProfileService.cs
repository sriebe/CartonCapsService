using CartonCapsService.Models;

namespace CartonCapsService.Services
{

    public class UserProfileService : IUserProfileService
    {
        public IEnumerable<Person> GetUserFriendList(String user)
        {
            // TODO: Call Repository class to pull data from database
            List<Person> friends = new List<Person>();
            friends.Add(new Person(1, "Bob", "Ross"));
            friends.Add(new Person(2, "Frank", "Zappa"));
            return friends;
        }
    }

}
