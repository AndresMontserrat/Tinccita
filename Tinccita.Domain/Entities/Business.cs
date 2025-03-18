using System.ComponentModel.DataAnnotations;

namespace Tinccita.Domain.Entities
{
    /// <summary>
    /// Business providing services
    /// </summary>
    public class Business
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Category>? Categories { get; set; }

        //TODO: LOCATION
        //TODO: CONTACT DETAILS
        //TODO: LOGO
        //TODO: DESCRIPTION
    }
}
