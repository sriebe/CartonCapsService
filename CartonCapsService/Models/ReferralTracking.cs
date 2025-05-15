namespace CartonCapsService.Models
{
    public class ReferralTracking
    {
        public string ReferralCode { get; set; }
        public string ReferralType { get; set; } // Text, Email, Share
        public string ReferralStatus { get; set; } // Unknown, Inivite Sent, Complete
        public string ReferralTimestamp { get; set; }
        public string RefereeFirstName { get; set; }
        public string RefereeLastName { get; set; }
        public string? RefereePhone { get; set; }
        public string? RefereeEmail { get; set; }

    }
}
