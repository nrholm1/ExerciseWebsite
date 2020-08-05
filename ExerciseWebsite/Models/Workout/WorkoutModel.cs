namespace ExerciseWebsite.Models.Workout
{
    public class WorkoutModel
    {
        public int Id { get; set; }
        public int SetListId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double AvgDifficulty { get; set; }
        public int Rating { get; set; }
        public int RatingCount { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
