using System.Linq;

public class CombinedCharacters : ICharacters
{
	private readonly string _characterSet;
	
	public CombinedCharacters(params ICharacters[] characters)
	{
		_characterSet = characters.Aggregate("", (a, c) => a + c.Get());
	}

	public string Get() => _characterSet;
}