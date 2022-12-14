using System.ComponentModel.DataAnnotations;

namespace FileUploadExample.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        public string Title { get; set; }

        public string PhotoUrl { get; set; }
    }

    public class CreatePhotoViewModel
    {
        [Required]
        public string Title { get; set; }

        public IFormFile UploadFile { get; set; }
    }
}