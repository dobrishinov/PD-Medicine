namespace PD_Medicine.Models
{
    using DataAccess.Entity;
    using DataAccess.Service;
    using System.Web;

    public static class AuthenticationManager
    {
        public static UserEntity LoggedUser
        {
            get
            {
                Auth auth = null;

                if (HttpContext.Current != null && HttpContext.Current.Session["LoggedUser"] == null)
                    HttpContext.Current.Session["LoggedUser"] = new Auth();

                auth = (Auth)HttpContext.Current.Session["LoggedUser"];
                return auth.LoggedUser;
            }
        }

        public static AdminEntity LoggedAdmin
        {
            get
            {
                Auth auth = null;

                if (HttpContext.Current != null && HttpContext.Current.Session["LoggedAdmin"] == null)
                    HttpContext.Current.Session["LoggedAdmin"] = new Auth();

                auth = (Auth)HttpContext.Current.Session["LoggedAdmin"];
                return auth.LoggedAdmin;
            }
        }

        public static void Authenticate(string username, string password)
        {
            Auth authenticationService = null;

            if (HttpContext.Current != null && HttpContext.Current.Session["LoggedUser"] == null)
                HttpContext.Current.Session["LoggedUser"] = new Auth();

            authenticationService = (Auth)HttpContext.Current.Session["LoggedUser"];
            authenticationService.AuthenticateUser(username, password);
        }

        public static void AuthenticateAdmin(string username, string password)
        {
            Auth authenticationService = null;

            if (HttpContext.Current != null && HttpContext.Current.Session["LoggedAdmin"] == null)
                HttpContext.Current.Session["LoggedAdmin"] = new Auth();

            authenticationService = (Auth)HttpContext.Current.Session["LoggedAdmin"];
            authenticationService.AuthenticateAdmin(username, password);
        }

        public static void Logout()
        {
            HttpContext.Current.Session["LoggedUser"] = null;
        }
    }
}