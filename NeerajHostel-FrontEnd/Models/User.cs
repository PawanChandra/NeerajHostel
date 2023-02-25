namespace NeerajHostel_FrontEnd.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string? Contact { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
