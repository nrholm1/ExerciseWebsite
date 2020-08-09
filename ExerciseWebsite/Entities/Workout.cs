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
        public double Rating { get; set; } // must start over to alter column in Db sadly
        public int RatingCount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
