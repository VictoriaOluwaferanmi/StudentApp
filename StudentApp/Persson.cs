namespace StudentApp
{
    public class Persson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Persson(string firstName, string lastName, string email, string phone, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;

        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string GetSimpleDetails()
        {
            return $"FirstName:{FirstName}/n" +
                   $"LastName:{LastName}/n" +
                   $"Email: {Email}/n" +
                   $"Address: {Address}";

        }
    }
}