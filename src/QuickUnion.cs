using System;
namespace UnionFind
{
	public class QuickUnion : IUF
	{
		int[] _id;

		public QuickUnion(int number)
		{
			_id = new int[number];
			for (int i = 0; i < number; i++)
			{
				_id[i] = i;
			}
		}

		int root(int i)
		{
			while (i != _id[i])
			{
				i = _id[i];
			}
			return i;
		}

		public bool Connected(int p, int q)
		{
			return root(p) == root(q);
		}

		public void Union(int p, int q)
		{
			int i = root(p);
			int j = root(q);
			_id[i] = j;
		}
	}
}
