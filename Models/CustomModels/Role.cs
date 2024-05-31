using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models.CustomModels
{
    public class Role
    {
        internal class RoleMetaData
        {
            [Required(ErrorMessage = "Please enter role type!")]
            [RegularExpression("^[a-zA-Z\\s\\W]+$", ErrorMessage = "Role Should only contain alphabets, spaces or special characters.")]
            public string roleType { get; set; }
        }
    }
}