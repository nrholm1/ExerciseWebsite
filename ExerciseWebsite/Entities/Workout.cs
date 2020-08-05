using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseWebsite.Entities
{
    public class Workout
    {
        public int Id { get; set; }

        [ForeignKey("SetList")]
        public int SetListId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double AvgDifficulty { get; set; }
        public int Rating { get; set; }
        public int RatingCount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
