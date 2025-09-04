
using MyMonkeyApp;

/// <summary>
/// Main entry point for the Monkey Console Application.
/// </summary>
namespace MyMonkeyApp;

class Program
{
	static void Main()
	{
		Console.WriteLine("Welcome to the Monkey Console Application!\n");
		bool running = true;
		while (running)
		{
			var monkey = MonkeyHelper.GetRandomMonkey();
			if (monkey == null)
			{
				Console.WriteLine("No monkeys available in the collection.");
				break;
			}

			DisplayMonkey(monkey);

			Console.WriteLine("\nOptions:");
			Console.WriteLine("1. Pick another monkey");
			Console.WriteLine("2. Exit");
			Console.Write("Select an option: ");
			var input = Console.ReadLine();
			running = input == "1";
		}
		Console.WriteLine("Goodbye!");
	}

	/// <summary>
	/// Displays monkey details in the console.
	/// </summary>
	/// <param name="monkey">The monkey to display.</param>
	static void DisplayMonkey(Monkey monkey)
	{
		Console.WriteLine("------------------------------");
		if (!string.IsNullOrWhiteSpace(monkey.AsciiArt))
			Console.WriteLine(monkey.AsciiArt);
		Console.WriteLine($"Name: {monkey.Name}");
		Console.WriteLine($"Scientific Name: {monkey.ScientificName}");
		Console.WriteLine($"Location: {monkey.Location}");
		Console.WriteLine($"Population: {(monkey.Population.HasValue ? monkey.Population.Value.ToString() : "Unknown")}");
		Console.WriteLine($"Conservation Status: {monkey.ConservationStatus}");
		Console.WriteLine($"Lifespan: {(monkey.Lifespan.HasValue ? monkey.Lifespan.Value + " years" : "Unknown")}");
		Console.WriteLine($"Weight: {(monkey.WeightKg.HasValue ? monkey.WeightKg.Value + " kg" : "Unknown")}");
		Console.WriteLine($"Height: {(monkey.HeightCm.HasValue ? monkey.HeightCm.Value + " cm" : "Unknown")}");
		Console.WriteLine($"Diet: {monkey.Diet}");
		Console.WriteLine($"Description: {monkey.Description}");
		// Example: Display geographic coordinates if available (add properties if needed)
		// Console.WriteLine($"Coordinates: {monkey.Latitude}, {monkey.Longitude}");
		Console.WriteLine("------------------------------");
	}
}
