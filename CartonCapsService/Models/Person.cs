namespace CartonCapsService.Models
{
    public class Person(int id, string firstName, string lastName)
    {
        public int Id { get; set; } = id;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public int ReferralStatus { get; set; } = (int)ReferralStatusEnum.Unknown;
        public string? ReferralCode { get; set; }
    }
}
