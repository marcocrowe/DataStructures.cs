namespace com.markcrowe.DataStructures
{
	using System;
	class Program
	{
		static void Main()
		{
			StackConsoleApp stackConsoleApp = new(new ChainLinkStack<String>());
			stackConsoleApp.Execute();
		}
	}
}