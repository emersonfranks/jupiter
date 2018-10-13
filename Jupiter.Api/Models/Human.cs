using System;

namespace Jupiter.Api.Models
{
    /// <summary>
    ///     Represents a human.
    /// </summary>
    public sealed class Human
    {
        /// <summary>
        ///     The name.
        /// </summary>
        public readonly string Name;

        /// <summary>
        ///     The <see cref="DateTime"/> of the human's birth.
        /// </summary>
        public readonly DateTime DateOfBirth;

        public Human(DateTime dateOfBirth, string name)
        {
            this.DateOfBirth = dateOfBirth;
            this.Name = name;
        }

        /// <summary>
        ///     Used to get the age of the human.
        /// </summary>
        /// <returns>The age in years.</returns>
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
    }
}
