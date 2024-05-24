using Core.Models;
using Core.RepostoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.RepostoryAbstract
{
	public  interface IGenericRepostory<T> where T : BaseEntity, new()	
	{
		Task AddAsync(T entity );
		void Delete( T entity );
		List<T> GetAll(Func<T,bool>? func=null);
		T Get (Func<T, bool>? func = null);	
		int Commit();
	    Task CommitAsync();

	}
}
