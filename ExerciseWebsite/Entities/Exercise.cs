using System.ComponentModel.DataAnnotations;

namespace ExerciseWebsite.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string MainMuscleGroup { get; set; }
        public string SecondaryMuscleGroup { get; set; }
        [Required]
        public string ExType { get; set; }
        [Required]
        public double Difficulty { get; set; }
    }
}