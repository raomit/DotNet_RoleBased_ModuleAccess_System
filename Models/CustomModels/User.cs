using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExamTaskMitRao.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(UserMetaDetaClass))]
    public partial class User
    {
        public class UserMetaDetaClass
        {
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

            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<RolesUser> RolesUsers { get; set; }
        }
    }
}