using System.ComponentModel.DataAnnotations;

namespace TestApi.Dtos
{
    public class CreateGenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
