using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MELib;


namespace MEWeb.Examples
{

  public partial class PageCards : MEPageBase<PageCardsVM>
  {

  }
  public class PageCardsVM : MEStatelessViewModel<PageCardsVM>
  {

        public bool FoundUserMoviesInd { get; set; }

        public string LoggedInUserName { get; set; }

    

        public MELib.Movies.UserMovieList UserMovieList { get; set; }

        public MELib.Accounts.AccountList UserAccountList { get; set; }
        public MELib.Accounts.Account UserAccount { get; set; }


        public MELib.AccountTypes.AccountTypeList AccountTypeList { get; set; }
        public MELib.AccountTypes.AccountType AccountType { get; set; }

        public MELib.RO.ROUser User { get; set; }
        public MELib.RO.ROUserList UserList { get; set; }
        public MELib.Movies.MovieList MovieList { get; set; }
        public int MovieID { get; set; }

        public PageCardsVM()
    {

    }

    protected override void Setup()
    {
      base.Setup();

    
            UserMovieList = MELib.Movies.UserMovieList.GetUserMovieList();
            UserAccountList = MELib.Accounts.AccountList.GetAccountList();
            AccountTypeList = MELib.AccountTypes.AccountTypeList.GetAccountTypeList();
            UserList = MELib.RO.ROUserList.GetROUserList();

          
            AccountType = AccountTypeList.FirstOrDefault();
            User = UserList.FirstOrDefault();
            UserAccount = UserAccountList.FirstOrDefault();


            if (UserMovieList.Count() > 0)
            {
                FoundUserMoviesInd = true;
            }
            else
            {
                FoundUserMoviesInd = false;
            }
            MovieID = System.Convert.ToInt32(Page.Request.QueryString[0]);

            MovieList = MELib.Movies.MovieList.GetMovieList(MovieID);




            LoggedInUserName = Singular.Security.Security.CurrentIdentity.UserName;
        }
  }
}


