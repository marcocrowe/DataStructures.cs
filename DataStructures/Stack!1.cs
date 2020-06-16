namespace com.markcrowe.DataStructures
{
	using System;
	using System.Collections.Generic;
	/// <summary>
	/// Represents a simple last-in-first-out (LIFO) generic collection of objects.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface Stack<T> : IEnumerable<T>
	{
		#region Properties
		#endregion
		/// <summary>
		/// Returns the number of items in this stack.
		/// </summary>
		Int32 Size { get; }
		#region Methods
		#endregion
		/// <summary>
		/// Removes all of the elements from this Stack. The Stack will be empty after this call returns(unless it throws an exception).
		/// </summary>
		void Clear();
		/// <summary>
		/// Returns the object at the top of the Stack without removing it.
		/// </summary>
		T Peek();
		/// <summary>
		/// Removes and returns the object at the top of the Stack.
		/// </summary>
		/// <returns>The T removed from the top of the Stack.
		T Pop();
		/// <summary>
		/// Inserts an object at the top of the System.Collections.Stack
		/// </summary>
		/// <param name="item">The item to push onto the Stack.</param>
		void Push(T item);
		#region Methods - Status
		#endregion
		/// <summary>
		/// Tests if this stack is empty.
		/// </summary>
		/// <returns>{@code true} if and only if this stack contains no items; {@code false} otherwise.</returns>
		Boolean IsEmpty();
	}
}