using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helper
{
    public static class Extension
    {
        public static string GetPath(string root, params string[] folders)
        {
            string resultPath = root;
            foreach (var folder in folders)
            {
                resultPath = Path.Combine(resultPath, folder);
            }
            return resultPath;
        }
        public static bool CheckFileSize(this IFormFile file, int kb)
        {
            return file.Length / 1024 <= kb;
        }
        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }
        public async static Task<string> SaveFileAsync(this IFormFile file, string root, params string[] folders)
        {
            var fileName = Guid.NewGuid().ToString() + file.FileName;
            var resultPath = Path.Combine(GetPath(root, folders), fileName);
            using (FileStream filestream =
                new FileStream(resultPath, FileMode.Create))
            {
                await file.CopyToAsync(filestream);

            }
            return fileName;
        }
    }
}
