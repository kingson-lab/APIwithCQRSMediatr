namespace APIwithCQRSMediatr.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        public required string Email { get; set; }
        public required string Mobile { get; set; }
    }
}
