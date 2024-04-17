namespace FJMdraft.OriModels
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int StatusId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
