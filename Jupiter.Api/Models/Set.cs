namespace Jupiter.Api.Models
{
    /// <summary>
    ///     A set from a workout.
    /// </summary>
    public class Set
    {
        public int Reps { get; set; }
        public string LiftName { get; set; } // This should not be a string long term...
        public int Weight { get; set; }
    }
}
