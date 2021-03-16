using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("hi what is your name");
		string name = Console.ReadLine();
		Console.WriteLine("hi " + name);
		Console.WriteLine("I am a calculater");
		Console.WriteLine("enter a number");
		int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the sign");
		String x = Console.ReadLine();
		Console.WriteLine("enter the second number");
    int b = Convert.ToInt32(Console.ReadLine());
	 
		int c = a + b;
		int d = a - b;
		int e = a / b;
		int f = a * b;
		if(x=="+"){
    Console.WriteLine("result: " + c);
		}
		else if(x=="-"){
     	Console.WriteLine("result: " +d);
		}
		else if(x=="/"){
     Console.WriteLine("result: " + e);
		}
		else if(x=="*"){
     Console.WriteLine("result: " + f);
		}
		else{
			Console.WriteLine("please enter a valid sign");
		}
	Console.WriteLine("I hope you like this calculater");
	Console.WriteLine("Bye!!!");
	string q = Console.ReadLine();
	Console.WriteLine(q);
  }
}