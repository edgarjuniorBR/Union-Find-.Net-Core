using System;
namespace UnionFind
{
	public class QuickFindUF : IUF
	{
		int[] _id;

		public QuickFindUF(int number)
		{
			_id = new int[number];
			for (int i = 0; i < number; i++)
			{
				_id[i] = i;
			}
		}

		public bool Connected(int p, int q)
		{
			return _id[p] == _id[q];
		}

		public void Union(int p, int q)
		{
			int pid = _id[p];
			int qid = _id[q];
			for (int i = 0; i < _id.Length; i++)
			{
				if (_id[i] == pid) _id[i] = qid;
			}
		}
	}
}
