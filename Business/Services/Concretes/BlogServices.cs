using Business.Exceptions;
using Business.Extention;
using Business.Services.Abstract;
using Core.Models;
using Data.RepostoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;

namespace Business.Services.Concretes
{
	public class BlogServices : IBlogServices


	{
		private readonly IBlogRepostory _blogRepostory;
		

	

		public Task AddBlogAsync(Blog blog)
		{
			if (blog.ImageFile == null)
				throw new ImageFileNotExcpetion("File tapilmadi");
			_blogRepostory.Helper.SaveFile();
			_blogRepostory.AddAsync(blog);
			_blogRepostory.Commit();
		}

		public int Commit()
		{
			return _blogRepostory.Commit();	
		}

		public Task CommitAsync()
		{
			return _blogRepostory.CommitAsync();
		}
		public void DeleteBlog(int id)
		{
			var existblog=_blogRepostory.Get(x => x.Id == id);
			if (existblog != null)
				throw new EntityException("silindi");
			_blogRepostory.Delete(existblog);
			_blogRepostory.Commit();
		}

		public void UpdateBlog(int id, Blog newblog)
		{
		  var oldBlog = _blogRepostory.Get(x=>x.Id == id);
			if (oldBlog != null)
				throw new Exceptions.FileNotFoundException("Bosdur");
			if (newblog.ImageFile != null)
				throw new Exceptions.FileNotFoundException("Bosdur");
			Helper.DeleteFile();

		}
	}
}
