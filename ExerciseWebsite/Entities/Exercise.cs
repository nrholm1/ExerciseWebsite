namespace ExerciseWebsite.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MuscleGroup { get; set; }
        public string ExType { get; set; }
        public int Difficulty { get; set; }
    }
}
