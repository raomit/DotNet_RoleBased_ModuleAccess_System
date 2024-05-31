using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models
{
<<<<<<< HEAD
=======
    using MvcExamTaskMitRao.Models.CustomModels;
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(UserMetaDetaClass))]
    public partial class User
    {
        public class UserMetaDetaClass
        {
<<<<<<< HEAD
            public int UserId { get; set; }
            [EmailAddress(ErrorMessage = "Please typein valid email address")]
            [Required(ErrorMessage = "this field is required")]
            public string Email { get; set; }
            [Required(ErrorMessage = "this field is required")]
            public Nullable<System.DateTime> BirthDate { get; set; }
            [Required(ErrorMessage = "this field is required")]
            [MinLength(10)]
            [MaxLength(10)]
            public string ContactNo { get; set; }
            [Required(ErrorMessage = "this field is required")]
            public string Fullname { get; set; }
            [Required(ErrorMessage = "this field is required")]
            [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{4,}$", ErrorMessage = "Password should have atleast one small and one big alphabet character, a number and a special character")]
            public string Password { get; set; }
            public string Type { get; set; }
            public Nullable<System.DateTime> CreatedOn { get; set; }
            public Nullable<System.DateTime> UpdatedOn { get; set; }
            public Nullable<int> CratedBy { get; set; }
            public Nullable<int> Isdeleted { get; set; }
=======
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
>>>>>>> 9fd577dc6259ea9bd5308c32a72a08f9358d1f21

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<RolesUser> RolesUsers { get; set; }
        }
    }
}