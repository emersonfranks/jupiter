using System;
using System.Collections.Generic;

namespace Jupiter.Api.Models
{
    /// <summary>
    ///     Trackable data for a workout.
    /// </summary>
    public class Workout
    {
        public DateTime EndTimeUtc { get; set; }
        public DateTime StartTimeUtc { get; set; }
        public IList<Exercise> Exercises { get; set; }
        public int WorkoutDurationInMinutes => (StartTimeUtc - EndTimeUtc).Minutes;
    }
}
