using Testapp.Models;
public class Program 
{

	private static void Main(string[] args)
	{
		Teacher tea = new Teacher();
		tea.EnterData();
		tea.Display();
	}
}