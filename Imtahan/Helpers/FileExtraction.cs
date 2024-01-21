using Microsoft.AspNetCore.Http;

namespace Imtahan.Helpers
{
    public static class FileExtraction
    {
        public static bool IsValidType(this IFormFile file) => file.ContentType.Contains("image");


        public static async Task<string> SaveAsync(this IFormFile file,string path)
        {
            string fileName = Path.Combine(path, Guid.NewGuid +  file.FileName);
            string filePath = Path.Combine(PathConstant.RootPath,fileName);

            using(Stream fs = new FileStream(filePath, FileMode.Create))
            {
               await file.CopyToAsync(fs);
            }
            return fileName;
        }
    }
}
