using System.Linq;

public class CompleteCharacters : ICharacters
{
	private readonly string _characters;
	
	public CompleteCharacters()
	{
		_characters = Enumerable.Range(0, '~' - ' ' + 1).Aggregate("", (a, i) => a + (char)(i + ' '));
	}

	public string Get() => _characters;
}