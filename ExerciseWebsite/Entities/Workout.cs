using System;

namespace ExerciseWebsite.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public int AvgDifficulty { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
