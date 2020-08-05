namespace ExerciseWebsite.Models.Workout
{
    public class CreateWorkout
    {
        public int SetListId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double AvgDifficulty { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
