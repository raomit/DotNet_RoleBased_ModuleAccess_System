using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models.CustomModels
{
    public class UpdateRoleAccess
    {
        public int roleId { get; set; }
        public int menuId { get; set; }
        public bool isChecked { get; set; }
    }
}