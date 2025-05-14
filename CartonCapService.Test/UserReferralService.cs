using CartonCapsService.Services;

namespace CartonCapService.Test
{
    public class UserReferralService
    {
        [Fact]
        public void GetUserFriendListShouldReturnSomething()
        {
            // In a real world application, I may mock the repository layer and set up expectations 
            // regarding the return. This becomes more meaningful if we are performing any business 
            // logic in the service. Otherwise we are really just testing that the service layer will
            // return what the repository layer provides.
            var sut = new CartonCapsService.Services.UserReferralService();
            var friendList = sut.GetUserFriendList("s");
            Assert.Equal(2, friendList.Count());

        }
    }
}