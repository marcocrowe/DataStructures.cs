namespace com.markcrowe.DataStructures
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	/// <summary>
	/// ChainLinkNode Enumerator
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal class ChainLinkNodeEnumerator<T> : IEnumerator<T>
	{
		internal ChainLinkNodeEnumerator(ChainLinkNode<T> firstLinkInChain)
		{
			currentChainLinkNode = this.firstLinkInChain = firstLinkInChain;
		}
		#region Properties
		#endregion
		public T Current { get; private set; }
		#region Public Methods
		#endregion
		public void Dispose()
		{
			this.currentChainLinkNode = null;
		}
		public Boolean MoveNext()
		{
			if (this.currentChainLinkNode != null)
			{
				Current = currentChainLinkNode.Value;
				currentChainLinkNode = currentChainLinkNode.NextNodeLinkedInChain;
				return true;
			}
			return false;
		}
		public void Reset()
		{
			currentChainLinkNode = this.firstLinkInChain;
			Current = default;
		}
		#region Private Fields
		#endregion
		private readonly ChainLinkNode<T> firstLinkInChain;
		private ChainLinkNode<T> currentChainLinkNode;
		#region IEnumerator - Memebers
		#endregion
		Object IEnumerator.Current => currentChainLinkNode.Value;
	}
}