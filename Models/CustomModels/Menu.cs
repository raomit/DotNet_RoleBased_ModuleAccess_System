using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models
{
    [MetadataType(typeof(MenuMetaData))]
    public partial class Menu
    {
        internal class MenuMetaData
        {
            [Required(ErrorMessage = "Please enter menu item!")]
            [RegularExpression("^[a-zA-Z\\s\\W]+$", ErrorMessage = "Should only contain alphabets, spaces or special characters.")]
            public string menuType { get; set; }
        }
    }
}