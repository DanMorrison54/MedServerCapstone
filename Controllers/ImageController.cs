using MedServerCapstone.DataModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;


namespace MedServerCapstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        public static IWebHostEnvironment _env;

        public ImageController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public async Task<object> Post([FromForm] ImageData imageData)
        {
            try
            {
                if (imageData.imageFile.Length > 0)
                {
                    string path = _env.WebRootPath + "\\images\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + imageData.imageFile.FileName))
                    {
                        imageData.imageFile.CopyTo(fileStream);
                        fileStream.Flush();
                        return "Upload Done";
                    }
                }
                else
                {
                    return "Image Uploading Failed";
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpGet("{filename}")]
        public async Task<IActionResult> Get([FromRoute] string filename)
        {
            string path = _env.WebRootPath + "\\images\\";
            var filePath = path + filename + ".png";

            if (System.IO.File.Exists(filePath))
            {
                byte[] _bytes = System.IO.File.ReadAllBytes(filePath);
                return File(_bytes, "image/png");
            }

            return null;
        }
    }
}
