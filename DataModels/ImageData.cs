using Microsoft.AspNetCore.Http;
using Microsoft.ML.Data;

namespace MedServerCapstone.DataModels

{
    public class ImageData
    {
        [ColumnName("Label"), LoadColumn(0)]
        public string Label { get; set; }


        [ColumnName("ImageSource"), LoadColumn(1)]
        public string ImageSource { get; set; }


    }
}
