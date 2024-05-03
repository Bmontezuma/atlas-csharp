using System;
class Program
{
	static void Main(string[] args)
        {
		float number = 3.1i4159f;
		float roundedNumber = (float)Math.Round(number, 2);
		Console.WriteLine(roundedNumber);
        }
}
