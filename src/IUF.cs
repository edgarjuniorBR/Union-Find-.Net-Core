using System;
namespace UnionFind
{
	public interface IUF
	{
		void Union(int p, int q);
		bool Connected(int p, int q);
	}
}
