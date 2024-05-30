using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models
{
    using MvcExamTaskMitRao.Models.CustomModels;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(UserMetaDetaClass))]
    public partial class User
    {
        public class UserMetaDetaClass
        {
            public int userId { get; set; }
            [EmailAddress(ErrorMessage = "Please typein valid email address")]
            [Required(ErrorMessage = "this field is required")]
            public string email { get; set; }
            [Required(ErrorMessage = "this field is required")]
            [Min18YearsOld(ErrorMessage = "You must be at least 18 years old.")]
            public Nullable<System.DateTime> birthDate { get; set; }
            [Required(ErrorMessage = "this field is required")]
            [MinLength(10)]
            [MaxLength(10)]
            public string contactNo { get; set; }
            [Required(ErrorMessage = "this field is required")]
            [RegularExpression("^[a-zA-Z\\s]+$", ErrorMessage = "Name Should only contain alphabets or spaces")]
            public string fullName { get; set; }
            [Required(ErrorMessage = "this field is required")]
            [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{4,}$", ErrorMessage = "Password should have atleast one small and one big alphabet character, a number and a special character")]
            public string password { get; set; }
            public string type { get; set; }

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<RolesUser> RolesUsers { get; set; }
        }
    }
}