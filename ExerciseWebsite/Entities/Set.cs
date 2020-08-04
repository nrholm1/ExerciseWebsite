using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseWebsite.Entities
{
    public class Set
    {
        public int Id { get; set; }
        
        [ForeignKey("Exercise")]
        public int ExerciseId { get; set; }

        [ForeignKey("SetList")]
        public int SetListId { get; set; }
        public int SetCount { get; set; }
        public int RepCount { get; set; }
    }
}
