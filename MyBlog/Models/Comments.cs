using Microsoft.Build.Framework;



namespace MyBlog.Models
{
    public class Comments
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        
    }
}
