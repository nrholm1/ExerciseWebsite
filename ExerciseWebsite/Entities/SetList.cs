﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseWebsite.Entities
{
    public class SetList
    {
        public int Id { get; set; }

        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }
        public int OrderNo { get; set; }
        public DateTime DateAdded { get; set; }
    }
}