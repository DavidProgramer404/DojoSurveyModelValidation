using System.ComponentModel.DataAnnotations;

namespace DojoSurveyModel.Models
{
    public class Survey
    {
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(2, ErrorMessage = "Message must be at least 2 characters in length.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required!")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Favorite is required!")]
        public string Favorite { get; set; }

        [Required(ErrorMessage = "Comment is required!")]
        [MinLength(20, ErrorMessage = "Message must be at least 20 characters in length.")]
        public string Comment { get; set; }

        public Survey() { }

        public Survey(string name, string location, string favorite, string comment)
        {
            Name = name;
            Location = location;
            Favorite = favorite;
            Comment = comment;
        }
    }
}