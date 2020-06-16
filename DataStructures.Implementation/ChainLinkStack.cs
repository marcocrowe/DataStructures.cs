namespace com.markcrowe.DataStructures
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	/// <summary>
	/// Represents a simple last-in-first-out (LIFO) generic collection of objects.
	/// Implemented as a dynamic chain linked list.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class ChainLinkStack<T> : Stack<T>
	{
		public ChainLinkStack()
		{
			InitializeComponent();
		}
		#region Properties
		#endregion
		public Int32 Size { get; private set; }
		#region Public Methods
		#endregion
		public void Clear()
		{
			this.InitializeComponent();
		}
		public IEnumerator<T> GetEnumerator()
		{
			return new ChainLinkNodeEnumerator<T>(this.firstLinkInChain);
		}
		public T Peek()
		{
			if (this.IsEmpty())
			{
				throw new InvalidOperationException("The Stack is Empty.");
			}
			return this.firstLinkInChain.Value;
		}
		public T Pop()
		{
			T firstItem = this.Peek();
			this.RemoveFirstLinkInChain();
			return firstItem;
		}
		public void Push(T item)
		{
			ChainLinkNode<T> chainLinkNode = new(item);
			this.Push(chainLinkNode);
		}
		#region Public Methods
		#endregion
		public Boolean IsEmpty()
		{
			//return (this.size == 0);
			return this.firstLinkInChain == null;
		}
		#region Private Methods
		#endregion
		private void Push(ChainLinkNode<T> chainLinkNode)
		{
			chainLinkNode.NextNodeLinkedInChain = this.firstLinkInChain;
			this.firstLinkInChain = chainLinkNode;
			this.Size++;
		}
		private void RemoveFirstLinkInChain()
		{
			this.firstLinkInChain = this.firstLinkInChain.NextNodeLinkedInChain;
			this.Size--;
		}
		//
		//	Private Methods
		//
		private void InitializeComponent()
		{
			this.firstLinkInChain = null;
			this.Size = 0;
		}
		//
		//	Private Fields
		//
		private ChainLinkNode<T> firstLinkInChain;
		#region IEnumerable - Memebers
		#endregion
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}
}