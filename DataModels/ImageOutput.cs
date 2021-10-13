using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace MedServerCapstone.DataModels
{
    public class ImageOutput: ImageData
    {
        // ColumnName attribute is used to change the column name from
        // its default value, which is the name of the field.
        [ColumnName("PredictedLabel")]
        public String PredictedLabel { get; set; }
        public float[] Score { get; set; }
    }
}
