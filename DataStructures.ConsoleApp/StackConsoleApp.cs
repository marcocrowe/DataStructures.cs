namespace com.markcrowe.DataStructures
{
	using System;
	public class StackConsoleApp
	{
		public StackConsoleApp(Stack<String> stack)
		{
			this.stack = stack;
		}
		#region Public Methods
		#endregion
		public void Execute()
		{
			do
			{
				PrintInstructions();
				String userinput = Console.ReadLine();
				switch (userinput.ToLower())
				{
					case clear: Clear(); break;
					case count: Count(); break;
					case exit: ExitProgram(); break;
					case peek: Peek(); break;
					case pop: Pop(); break;
					case push: Push(); break;
					case print: default: Print(); break;
					case search: Search(); break;
				}
			}
			while (contineProgramLoop);
		}
		#region Private Methods - User Commands
		#endregion
		private void Clear()
		{
			if (stack.IsEmpty())
				DisplayToUser("The Stack is empty.  Nothing to clear.");
			else
			{
				stack.Clear();
				DisplayToUser($"The stack has been cleared.");
			}
		}
		private void Count()
		{
			Console.WriteLine($"Number of items in the stack: {stack.Size}");
		}
		private void ExitProgram()
		{
			contineProgramLoop = false;
			Console.WriteLine($"Exiting Program.");
		}
		private void Peek()
		{
			if (stack.IsEmpty())
				DisplayToUser("There is nothing in the Stack. Cannot execute Peek.");
			else
				DisplayToUser($"Peek on Stack returns: {this.stack.Peek()}");
		}
		private void Pop()
		{
			if (stack.IsEmpty())
				DisplayToUser("There is nothing in the Stack. Cannot execute Pop.");
			else
				DisplayToUser($"Pop on Stack returns: {this.stack.Pop()}");
		}
		private void Push()
		{
			DisplayToUser("Please enter a name:");
			String name = Console.ReadLine();
			stack.Push(name);
			DisplayToUser($"Pushed '{name}' on the Stack");
		}
		private void Search()
		{
			DisplayToUser("Please enter a name to search for:");
			String searchName = Console.ReadLine();

			foreach (String element in this.stack)
			{
				if (searchName.CompareTo(element) == 0)
				{
					DisplayToUser($"The Stack contains the name: {searchName}");
					return;
				}
			}
			DisplayToUser($"The Stack does not contain the name: {searchName}");
		}
		private void Print()
		{
			var stackText = "{";
			var enumerator = this.stack.GetEnumerator();
			//
			//  case 1
			//
			if (enumerator.MoveNext())
			{
				stackText += enumerator.Current;
			}
			//
			//	case n
			//
			while (enumerator.MoveNext())
			{
				stackText += $", {enumerator.Current}";
			}
			stackText += "}";
			//
			//	output
			//
			DisplayToUser($"The Stack: {stackText}");
		}
		#region Private Methods
		#endregion
		private void DisplayToUser(string message)
		{
			Console.WriteLine(message);
		}
		private void PrintInstructions()
		{
			Console.WriteLine();
			Console.WriteLine("Command Menu");
			Console.WriteLine($"Type '{clear}' to clear the Stack.");
			Console.WriteLine($"Type '{count}' to count the items in the Stack.");
			Console.WriteLine($"Type '{exit}' to exit the program.");
			Console.WriteLine($"Type '{peek}' to peek the Stack.");
			Console.WriteLine($"Type '{print}' to print the Stack.");
			Console.WriteLine($"Type '{pop}' to pop the Stack.");
			Console.WriteLine($"Type '{push}' to push an item on the Stack.");
			Console.WriteLine($"Type '{search}' to search for an item in the Stack.");

			Console.WriteLine($"Enter a command:");
		}
		#region Private Fields
		#endregion
		private readonly Stack<String> stack;
		private Boolean contineProgramLoop = true;
		#region Constant Fields
		#endregion
		const String exit = "exit";
		const String clear = "clear";
		const String count = "count";
		const String peek = "peek";
		const String pop = "pop";
		const String print = "print";
		const String push = "push";
		const String search = "search";
	}
}
