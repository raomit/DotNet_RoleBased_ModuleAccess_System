using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models.CustomModels
{
    public class UpdateRole
    {
        public int roleId { get; set; }
        public int userId { get; set; }
        public bool isChecked {  get; set; } 
    }
}