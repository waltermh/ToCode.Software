using System;

namespace HelloWorld
{
	public class MichaelBot
{
	public void Start()
	{
		Console.WriteLine("Hello World!");
		Console.WriteLine("Hows quarantine?");
		Console.WriteLine("Miss baseball?");
		var response = Console.ReadLine();
		if (response.ToLower() == "cubs")
		{
			Console.WriteLine("This year at Wriggly");
		}
	}
}

}