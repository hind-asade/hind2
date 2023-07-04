using BlazorApp2.RepositoriesPattern.Interfaces;

namespace BlazorApp2.RepositoriesPattern.Repositories
{
	public class Archiving_Repository : IArchiving
	{

		public int addTowNumbers(int Number1, int Number2)
		{
			int Result = Number1+ Number2;
			return Result
				;
		}
	}
}
