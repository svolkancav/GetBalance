using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.UI.Extensions
{
	public class PictureTools
	{
		public string CreatePictureFolder() { 
			string projectPath = Environment.CurrentDirectory;
			string picturePath = projectPath + "\\Pictures";
			try
			{
				if (!System.IO.Directory.Exists(picturePath))
				{
					System.IO.Directory.CreateDirectory(picturePath);
					return picturePath;
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Resimler dosya yolunda hata oluştu!"+ex.Message);
			}
			return picturePath;
		}

		public string CopyPicture(string sourcePath ) // sourcePath: resmin kaynak yolu, destinationPath: resmin kopyalanacağı yol
		{
			string destinationFolder =CreatePictureFolder();
			try
			{
				string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);

				string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

				System.IO.File.Copy(sourcePath, destinationPath);

				return destinationPath;
			}
			catch (Exception ex)
			{
				throw new Exception("Resim kopyalama işleminde hata oluştu!"+ex.Message);
			}
		}
	}
}
