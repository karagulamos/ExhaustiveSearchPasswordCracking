using System;
using System.Linq;
using System.Text;

public class Program
{
	public static void Main()
	{
		var cracker = new PasswordCracker(new DummyAuthenticator(), new CombinedCharacters(
			new LowercaseCharacters(), new UppercaseCharacters(), 
      new NumericCharacters(), new SpecialCharacters()
		));	
		
		// var cracker = new PasswordCracker(new DummyAuthenticator(), new CompleteCharacters());
		
		var result = cracker.Execute("Alex", 4);
		
		Console.WriteLine(result.Length > 0 ? result : "Unable to crack password!");
	}
}
