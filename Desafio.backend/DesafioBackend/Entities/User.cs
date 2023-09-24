namespace Desafio.Backend.Entities
{
    public class User
    {
        public User(string? name, string? document, string? email, string? password)
        {
            Id = new Guid();
            Name = name;
            Document = document;
            Email = email;
            Password = password;
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Document { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
