using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions option ) : base(option) 
		{ 

		}

	  public DbSet<Blog>blogs { get; set; }
	}

}
