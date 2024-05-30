//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Security;

//namespace MvcExamTaskMitRao.Models.CustomModels
//{
//    public class UserRoleProvider : RoleProvider
//    {
//        private String[] UserRole;
//        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
//        {
//            throw new NotImplementedException();
//        }

//        public override void CreateRole(string roleName)
//        {
//            throw new NotImplementedException();
//        }

//        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
//        {
//            throw new NotImplementedException();
//        }

//        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
//        {
//            throw new NotImplementedException();
//        }

//        public override string[] GetAllRoles()
//        {
//            throw new NotImplementedException();
//        }

//        public override string[] GetRolesForUser(string email)
//        {
//                using (ExamEntities _DbContext = new ExamEntities())
//                {
//                    this.UserRole = (from u in _DbContext.Users
//                                     join ru in _DbContext.RolesUsers on u.UserId equals ru.userId
//                                     join r in _DbContext.Roles on ru.roleId equals r.roleId
//                                     where u.Email == email
//                                     select r.roleName).ToArray();
//                    return this.UserRole;
//                }
//        }

//        public override string[] GetUsersInRole(string roleName)
//        {
//            throw new NotImplementedException();
//        }

//        public override bool IsUserInRole(string username, string roleName)
//        {
//            throw new NotImplementedException();
//        }

//        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
//        {
//            throw new NotImplementedException();
//        }

//        public override bool RoleExists(string roleName)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}