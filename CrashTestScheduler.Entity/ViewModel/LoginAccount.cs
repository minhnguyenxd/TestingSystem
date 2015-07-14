using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class LoginAccount
    {
        public string ErrorMessage { get; set; }
        public UserPrincipal userPrincipal { get; set; }
        public List<string> UserRoles { get; set; }
    }
}
