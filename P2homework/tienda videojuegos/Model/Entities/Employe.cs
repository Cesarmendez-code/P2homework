using System.ComponentModel.DataAnnotations.Schema;

namespace tienda_videojuegos.Model.Entities
{
    public class Employe
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; }
    }
}
