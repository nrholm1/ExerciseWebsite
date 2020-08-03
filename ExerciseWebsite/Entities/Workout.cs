using System;

namespace ExerciseWebsite.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double AvgDifficulty { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
