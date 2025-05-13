using CartonCapsService.Models;

namespace CartonCapsService.Services
{
    public interface IUserProfileService
    {
        IEnumerable<Person> GetUserFriendList(string user);
    }
}