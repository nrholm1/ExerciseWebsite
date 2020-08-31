namespace ExerciseWebsite.Models.Exercise
{
    public class CreateExercise
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string MainMuscleGroup { get; set; }
        public string SecondaryMuscleGroup { get; set; }
        public string ExType { get; set; }
        public double Difficulty { get; set; }
    }
}
