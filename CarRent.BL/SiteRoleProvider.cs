using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Security;
using System.Reflection;

namespace CarRent.BL
{
    class SiteRoleProvider : RoleProvider
    {
        private string applicationName=System.Reflection.Assembly.GetExecutingAssembly().GetName().ToString();
        public override string ApplicationName
        {
            get
            {
                return applicationName;
            }

            set
            {
               // throw new NotImplementedException();
            }
        }

        // ################ do implement from HERE

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            throw new NotImplementedException();
        }
        // ################ do implement until HERE

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }
    
        // ################ do also this
        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
