using RegisterAndLoginApp_2b_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp_2b_1.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { Id = 0, UserName = "BillGates", Password = "bigbucks" });
            knownUsers.Add(new UserModel { Id = 1, UserName = "MarieCurie", Password = "radioactive" });
            knownUsers.Add(new UserModel { Id = 2, UserName = "WatstonCrick", Password = "dna" });
            knownUsers.Add(new UserModel { Id = 3, UserName = "AlexanderFlemming", Password = "penicillin" });

        }

        public bool IsValid(UserModel user)
        {
            //return true if found in the list
            return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }

    }
}
