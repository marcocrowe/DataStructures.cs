namespace com.markcrowe.DataStructures
{
	internal class ChainLinkNode<T>
	{
		internal ChainLinkNode()
		{
		}
		internal ChainLinkNode(T item, ChainLinkNode<T> nextNodeLinkedInChain)
		{
			this.NextNodeLinkedInChain = nextNodeLinkedInChain;
			this.Value = item;
		}
		public ChainLinkNode(T item)
		{
			this.Value = item;
		}
		#region Public Properties
		#endregion
		public ChainLinkNode<T> NextNodeLinkedInChain { get; set; }
		public T Value { get; set; }
	}
}
