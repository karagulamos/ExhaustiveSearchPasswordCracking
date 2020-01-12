using System;
using System.Linq;
using System.Text;

public class Program
{
	public static void Main()
	{
    // The line below proves having more characters to choose from increases our search space.
    // Since we consider all characters between and inclusive of the "SPACE" and "~" characters,
    // we have O(M ^ N) runtime, where M (i.e. 95 characters in our chase) is the total number of 
    // characters we are considering and N is the maximum length of password we specied. Our space
    // complexity is O(N) since our recursion only grows that much.
    //
		// var cracker = new PasswordCracker(new DummyAuthenticator(), new CompleteCharacters());

    // A typical password cracking software will employ the use of a dictionary attack or
    // reduce the search space by combining this with one or more of the strategies below 
    //
		var cracker = new PasswordCracker(new DummyAuthenticator(), new CombinedCharacters(
			new LowercaseCharacters(), new UppercaseCharacters(), 
      new NumericCharacters(), new SpecialCharacters()
		));	
		
		var result = cracker.Execute("Alex", 4);
		
		Console.WriteLine(result.Length > 0 ? result : "Unable to crack password!");
	}
}
