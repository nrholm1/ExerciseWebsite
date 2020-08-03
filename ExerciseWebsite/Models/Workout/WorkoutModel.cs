using System;

namespace ExerciseWebsite.Models.Workout
{
    public class WorkoutModel
    {
        public int Id { get; set; }
        public int AvgDifficulty { get; set; }
        public int Rating { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
