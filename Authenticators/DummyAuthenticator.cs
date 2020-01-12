using System.Text;

public class DummyAuthenticator : IAuthenticator
{
	private readonly string _compare;
	
	public DummyAuthenticator() => _compare = "z@Z1";
	
	public bool Login(string username, StringBuilder password)
	{
		if (_compare.Length != password.Length)
			return false;
			
		for (var idx = 0; idx < _compare.Length; idx++)
		{
			if (_compare[idx] != password[idx])
				return false;
		}

		return true;
	}
}