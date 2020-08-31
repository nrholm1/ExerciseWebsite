namespace ExerciseWebsite.Models.Exercise
{
    public class ExerciseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainMuscleGroup { get; set; }
        public string SecondaryMuscleGroup { get; set; }
        public string ExType { get; set; }
        public double Difficulty { get; set; }
    }
}
