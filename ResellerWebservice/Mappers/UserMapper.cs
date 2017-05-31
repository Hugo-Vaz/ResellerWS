using ResellerWebservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Mappers
{
    public static class UserMapper
    {
        public static User ConvertWebserviceToInterface(ResellerWebservice.UserResponse wsUser)
        {
            User user = new User();
            user.Cellphone = wsUser.User.Celular;
            user.Login = wsUser.User.Login;
            user.CustomerID = wsUser.User.CustomerID;
            user.IsBlocked = Convert.ToBoolean(wsUser.User.Bloqueado);
            user.Name = wsUser.User.NomeUsuario;
            user.Password = wsUser.User.Senha;
            user.UniqueIdentifier = wsUser.User.CPF;
            user.AccountManagerCode = wsUser.User.CodVendedor;
            return user;
        }
    }
}