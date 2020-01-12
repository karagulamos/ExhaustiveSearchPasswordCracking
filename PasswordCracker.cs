using System.Text;

public class PasswordCracker
{
	private readonly IAuthenticator _authenticator;
	private readonly string _characters;
	
	public PasswordCracker(IAuthenticator authenticator, ICharacters characters)
	{
		_authenticator = authenticator;
		_characters = characters.Get();
	}

	public string Execute(string username, int passwordLength = 5)
	{
		return Helper(username, new StringBuilder(), passwordLength);
	}

	private string Helper(string username, StringBuilder password, int passwordLength)
	{
		if (_authenticator.Login(username, password))
			return password.ToString();
		
		if (passwordLength == 0)
			return string.Empty;
		
		foreach (var character in _characters)
		{
			var found = Helper(username, password.Append(character), passwordLength - 1);
			
			if (found.Length > 0)
				return found;
			
			password.Length--;
		}

		return string.Empty;
	}
}