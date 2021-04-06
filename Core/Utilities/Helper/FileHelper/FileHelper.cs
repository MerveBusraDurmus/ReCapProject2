﻿using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helper.FileHelper
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var result = newPath(file);

            var sourcepath = Path.GetTempFileName();

            using (var stream = new FileStream(sourcepath,FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Move(sourcepath, result.newPath);

            return result.Path2;
        }


        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            using (var stream= new FileStream(result.newPath,FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Delete(sourcePath);

            return result.Path2;
        }


        public static IResult Delete (string path)
        {
            //path = Environment.CurrentDirectory + @"\wwwroot\images\" + path;
            //if (!File.Exists(path))
            //{
            //    return new ErrorResult();
            //}
            File.Delete(path);
            return new SuccessResult();
        }


        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName); //instance oluşturuyoruz.
            var fileExtension = fileInfo.Extension;  //dosyanın uzantısını aldık.
            var newFileName = Guid.NewGuid().ToString("N") + fileExtension;  //yeni dosya adını oluşturduk
            string path12 = @"\wwwroot\Images"; 

            //Environment.CurrentDirectory = Uygulamanın çalıştığı aktif klasör yolu
            string result = Environment.CurrentDirectory + path12 + newFileName;  
            return (result, $"\\Images\\{newFileName}");

        }
    }
}
