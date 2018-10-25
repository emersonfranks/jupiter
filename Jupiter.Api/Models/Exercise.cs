using System.Collections.Generic;

namespace Jupiter.Api.Models
{
    /// <summary>
    ///     Represents information about a given exercise.
    /// </summary>
    public class Exercise
    {
        public IList<Set> Sets { get; set; }
        public BodyPartFocus BodyPartFocus { get; set; }
    }
}
