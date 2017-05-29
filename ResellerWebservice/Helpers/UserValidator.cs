using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ResellerWebservice.Helpers
{
    public static class UserValidator
    {
        public static void CheckUser(User user)
        {
            if(user == null)
            {
                FaultCode prionFaultCode = new FaultCode("101");
                throw new FaultException("User Error: The user can't be null.", prionFaultCode);
            }

            if (user.IsBlocked)
            {
                FaultCode prionFaultCode = new FaultCode("101");
                throw new FaultException("User Error: The user is blocked in the system.", prionFaultCode);
            }
        }
    }
}