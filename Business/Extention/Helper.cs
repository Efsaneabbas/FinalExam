using Business.Exceptions;
using Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileNotFoundException = Business.Exceptions.FileNotFoundException;

namespace Business.Extention
{
	public class Helper
	{
		public static string SaveFile(string root, string folder, IFormFile file)
		{
			if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
				throw new ImageContentType("Type uygun deyil");
			if (file.Length > 2097152)
				throw new ImageFileNotExcpetion(" MAx 2 mb olmalidir");

			string filename = Guid.NewGuid().ToString() + Path.GetFileName(root);
			string path = root + $@"\{folder}\" + filename;

			using FileStream fileStream = new FileStream(path, FileMode.Create);
			{
				file.CopyTo(fileStream);
			}
			return filename;
		
		
		}
		public static void DeleteFile(string path, string folder, string ImageFile)
		{
			string path = Path + $@"\{folder}\" + ImageFile;
			if (!File.Exists(path))
				throw new FileNotFoundException("Tapilmir");
			File.Delete(path);


		}
	}
}
