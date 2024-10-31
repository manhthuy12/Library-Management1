using System.ComponentModel.DataAnnotations;

namespace BussinessObject
{
    public class MemberObject
    {
        public int MemberID { get; set; }
        private string? _email;

        [EmailAddress(ErrorMessage = "Wrong format for Email!!")]
        public string Email
        {
            get { return _email!; }
            set { _email = value; }
        }
        public string? CompanyName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Password { get; set; }
    }
}
