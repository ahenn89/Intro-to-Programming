using System;
using Raspberry.IO.GeneralPurpose;
using System.Threading;

class SimpleGPIO {
	static void Main () {
		Console.WriteLine("Initializing GPIO Connection...");
		//create a connection to the desired GPIO pins
		//refer to the pinouts diagram for the correct pin
		OutputPinConfiguration red = ConnectorPin.P1Pin36.Output();
		OutputPinConfiguration green = ConnectorPin.P1Pin32.Output();
		
		var connection = new GpioConnection(green, red);
		
		Console.Write("1. Who is the President of the United States? ");
		
		Console.WriteLine("a. Puff Daddy");
		Console.WriteLine("b. Hillary Clinton");
		Console.WriteLine("c. Barack Obama");
		Console.WriteLine("d. George Bush");
		string ans = Console.ReadLine().ToLower();
		
		/*if (ans == "c") {
			OutputPinConfiguration led = green;
		}else {
			OutputPinConfiguration led = red;
		}*/
		OutputPinConfiguration led = ans == "c" ? green : red;
		
		for (int ctr = 0; ctr < 10; ctr++) {
			connection.Toggle(led);
			Thread.Sleep(150);
		}
		/*Console.WriteLine("Answer: ");*/
		
		/*Console.Write("2. Summer Solstice is the shortest day of the year.");
		Console.WriteLine("a. True");
		Console.WriteLine("b. False");
		string ans = Console.ReadLine().ToLower();
		
		OutputPinConfiguration led = ans == "a" ? green : red;*/
		
		//TODO: Add program code here
		connection.Close();				
	}	
}	
