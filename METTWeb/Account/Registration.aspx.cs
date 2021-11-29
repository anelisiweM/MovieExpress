using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web;

namespace MEWeb.Account
{
    public partial class Registration : MEPageBase<RegistrationVM>
    {
    }
     public class RegistrationVM : MEStatelessViewModel<RegistrationVM>
    {
       // public MELib.Users.User NewUser { get; set; }
        public MELib.TempUser.NewUser NewUser { get; set; }

        public RegistrationVM()
        {
        }
        protected override void Setup()
        {
            base.Setup();

           // NewUser = MELib.Users.User.NewUser();
            NewUser = MELib.TempUser.NewUser.NewNewUser();
        }




        [WebCallable(LoggedInOnly = true)]
        public Result NewUserRegistration(string FirstName, string LastName, string UserName, string EmailAddress, string ContactNo, string Password)
        //byte[] FirstName, string LastName, string UserName, string Password, string firstTimeUser, string EmailAddress)
        {



            Result sr = new Result();
            try
            {
                MELib.TempUser.NewUser myNewUserAccount = MELib.TempUser.NewUser.NewNewUser();
                myNewUserAccount.FirstName = Encoding.ASCII.GetBytes(FirstName);
                myNewUserAccount.LastName = Encoding.ASCII.GetBytes(LastName);
                myNewUserAccount.UserName = UserName;
                myNewUserAccount.Password = Encoding.ASCII.GetBytes(Password);
                myNewUserAccount.EmailAddress = EmailAddress;
                myNewUserAccount.Salt = Encoding.ASCII.GetBytes(Password);
                myNewUserAccount.PasswordChangeDate = Convert.ToDateTime(DateTime.Today.ToString());



                var save = myNewUserAccount.TrySave(typeof(MELib.TempUser.NewUserList));



                if (save.Success == true)
                {
                    return new Singular.Web.Result() { Success = true };
                }
                else
                {
                    sr.ErrorText = "User Not Added.";
                    sr.Success = false;
                }




            }
            catch (Exception Ex)
            {
                sr.ErrorText = "User Not Added." + Ex.ToString();
                sr.Success = false;
            }





            return sr;
        }
    }
}