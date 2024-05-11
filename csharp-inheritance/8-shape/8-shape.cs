using System;

namespace ShapeNamespace
{
    /// <summary>
    /// Represents a square.
    /// </summary>
    public class Square : Shape
    {
        private int size;

        /// <summary>
        /// Gets or sets the size of the square.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when size is set to a negative value.</exception>
        public int Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Size must be greater than or equal to 0");
                size = value;
            }
        }

        /// <summary>
        /// Calculates the area of the square.
        /// </summary>
        /// <returns>The area of the square.</returns>
        public override int Area()
        {
            return size * size;
        }
    }
}
