namespace AspNetCoreSecondProject.Models
{
    public class UserListVM
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public bool IsActive { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public bool IsActive { get; set; }
        public string Phonenumber { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
    }
}
