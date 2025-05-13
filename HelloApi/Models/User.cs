namespace HelloApi.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

    }
}
