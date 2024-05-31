using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models
{
    [MetadataType(typeof(ProductMenuItemMetaData))]
    public partial class ProductMenuItem
    {
        public class ProductMenuItemMetaData
        {
            public int id { get; set; }
            [Required(ErrorMessage = "Required")]
            public string itemname { get; set; }
            [Required(ErrorMessage = "Required")]
            public string itemdesc { get; set; }
            public Nullable<int> ProductMenuId { get; set; }

            public virtual ProductMenu ProductMenu { get; set; }
        }
    }
}