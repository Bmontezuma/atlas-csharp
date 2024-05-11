using System;

namespace csharp_interfaces
{
    /// <summary>
    /// Abstract base class for all objects.
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// The name of the object.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Returns a string representation of the object.
        /// </summary>
        /// <returns>A string representation of the object.</returns>
        public override string ToString()
        {
            return $"{name} is a {this.GetType().Name}";
        }
    }

    /// <summary>
    /// A software engineer.
    /// </summary>
    public class SoftwareEngineer : Base
    {
        // Empty class
    }
}
