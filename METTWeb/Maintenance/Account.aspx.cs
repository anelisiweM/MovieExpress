using Singular.Web.MaintenanceHelpers;

namespace MEWeb.Maintenance
{
    /// <summary>
    /// The Maintenance custom page class
    /// </summary>
    public partial class Account : MEPageBase<AccountVM>
    {
    }

    /// <summary>
    /// The MaintenanceVM ViewModel class
    /// </summary>
    public class AccountVM : StatelessMaintenanceVM
    {
        /// <summary>
        /// Setup the ViewModel
        /// </summary>
        protected override void Setup()
        {
            base.Setup();

            // Add Maintenance pages here.
            //MainSection mainSection = AddMainSection("General");
            //MainSection mainSection1 = AddMainSection("Products");

            MainSection mainSection2 = AddMainSection("User Accounts");

            //mainSection.AddMaintenancePage<MELib.Maintenance.MovieGenreList>("Movie Genres");
            //mainSection.AddMaintenancePage<MELib.Movies.MovieList>("All Movies");

            //mainSection1.AddMaintenancePage<MELib.Snacks.SnackTypeList>("Snack Type");
            //mainSection1.AddMaintenancePage<MELib.Snack.SnackList>("All Snack List");

            // mainSection2.AddMaintenancePage<MELib.Security.UserList>("Users");
            mainSection2.AddMaintenancePage<MELib.AccountTypes.AccountList>("User Account");

            // mainSection.AddMaintenancePage<MELib.Maintenance.>("Snack Type");

            // Add more lists here for maintaining, e.g. Status List, Years or lookup tables used in the project
        }
    }
}
