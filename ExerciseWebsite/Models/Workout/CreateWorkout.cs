using System;

namespace ExerciseWebsite.Models.Workout
{
    public class CreateWorkout
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
