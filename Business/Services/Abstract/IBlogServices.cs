
using Core.Models;
using Data.RepostoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstract
{
	public interface IBlogServices
	{
		Task AddBlogAsync(Blog blog);
		void DeleteBlog(int id);
		void UpdateBlog(int id, Blog newblog);
		List<Blog> GetAllBlog(Func<Blog,bool>? predicate = null);
		Blog GetBlog(Func<Blog,bool>? predicate=null);
		int Commit();
		
	}
}
