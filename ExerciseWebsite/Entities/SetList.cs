using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseWebsite.Entities
{
    public class SetList 
    {
        public int Id { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }

        [ForeignKey("Set")]
        public int SetId { get; set; }
        public int OrderNo { get; set; }
        public System.DateTime DateAdded { get; set; }
    }
}
