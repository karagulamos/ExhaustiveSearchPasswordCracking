using System.Text;

public interface IAuthenticator
{
	bool Login(string username, StringBuilder password);
}