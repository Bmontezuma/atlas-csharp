using System;

namespace Vehicle
{
    /// <summary>
    /// Represents a vehicle.
    /// </summary>
    public class Vehicle
    {
        /// <summary>
        /// Gets or sets the name of the vehicle.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle"/> class.
        /// </summary>
        /// <param name="name">The name of the vehicle.</param>
        public Vehicle(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Outputs a message indicating that the vehicle is driving.
        /// </summary>
        public virtual void Drive()
        {
            Console.WriteLine($"The {Name} is driving.");
        }
    }

    /// <summary>
    /// Represents a car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="name">The name of the car.</param>
        public Car(string name) : base(name)
        {
        }

        /// <summary>
        /// Outputs a message indicating that the car is accelerating.
        /// </summary>
        public override void Drive()
        {
            Console.WriteLine($"The {Name} is accelerating.");
        }
    }
}
