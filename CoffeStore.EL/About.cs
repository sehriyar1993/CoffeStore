using System.ComponentModel.DataAnnotations;

namespace CoffeStore.EL
{
    public class About
    {
        [Key]

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AboutUs { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }

    }
}