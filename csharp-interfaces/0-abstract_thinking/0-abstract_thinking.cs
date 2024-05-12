using System;

namespace Base
{
    /// <summary>
    /// Represents a base entity with a name.
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// Gets or sets the name of the entity.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns a string representation of the entity.
        /// </summary>
        /// <returns>A string representation of the entity.</returns>
        public override string ToString()
        {
            if (!string.IsNullOrEmpty(Name))
                return $"{Name} is a {GetType().Name}";
            else
                return $"{GetType().Name} (no name set)";
        }
    }

    /// <summary>
    /// Represents a software engineer entity.
    /// </summary>
    public class SoftwareEngineer : Base
    {
        /// <summary>
        /// Gets or sets the programming language the software engineer works with.
        /// </summary>
        public string ProgrammingLanguage { get; set; }

        /// <summary>
        /// Simulates the software engineer writing code.
        /// </summary>
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code in {ProgrammingLanguage}.");
        }
    }

    /// <summary>
    /// Represents a test object entity.
    /// </summary>
    public class TestObject : Base
    {
        /// <summary>
        /// Gets or sets a value indicating whether the test object is valid.
        /// </summary>
        public bool IsValid { get; set; }

        /// <summary>
        /// Runs tests on the test object.
        /// </summary>
        public void RunTests()
        {
            Console.WriteLine($"Running tests on {Name}. Result: {(IsValid ? "Pass" : "Fail")}");
        }
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
