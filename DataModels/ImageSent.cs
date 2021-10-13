using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedServerCapstone.DataModels
{
    public class ImageSent
    {
        public string ImageSource { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
