//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace miPT_Project_6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    public partial class UserWorkouts
    {
        [DisplayName("ID")]
        public string Id { get; set; }
        [DisplayName("Workout ID")]
        public int WorkoutID { get; set; }
        [DisplayName("User Workout ID")]
        public int UserWorkoutID { get; set; }
        [DisplayName("Date")]
        public System.DateTime Date { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual Workouts Workouts { get; set; }
    }
}
