using System;
using Singular.Web;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web.Data;
using MELib.RO;
using MELib.Security;
using Singular;

namespace MEWeb.Examples
{

  public partial class EditableTable : MEPageBase<EditableTableVM>
  {

  }
  public class EditableTableVM : MEStatelessViewModel<EditableTableVM>
  {
    public MELib.Movies.MovieList MovieList { get; set; }

		public MELib.Snacks.SnackList SnackList { get; set; }

		public EditableTableVM()
    {

    }

    protected override void Setup()
    {
      base.Setup();
      MovieList = MELib.Movies.MovieList.GetMovieList();

			SnackList = MELib.Snacks.SnackList.GetSnackList(); 
		}


		[WebCallable]
		public Result SaveMovieList(MELib.Movies.MovieList MovieList)
		{
			Result sr = new Result();
			if (MovieList.IsValid)
			{
				var SaveResult = MovieList.TrySave();
				if (SaveResult.Success)
				{
					sr.Data = SaveResult.SavedObject;
					sr.Success = true;
				}
				else
				{
					sr.ErrorText = SaveResult.ErrorText;
					sr.Success = false;
				}
				return sr;
			}
			else
			{
				sr.ErrorText = MovieList.GetErrorsAsHTMLString();
				return sr;
			}
		}

		[WebCallable]
		public Result SaveSnackList(MELib.Snacks.SnackList SnackList)
		{
			Result sr = new Result();
			if (SnackList.IsValid)
			{
				var SaveResult = SnackList.TrySave();
				if (SaveResult.Success)
				{
					sr.Data = SaveResult.SavedObject;
					sr.Success = true;
				}
				else
				{
					sr.ErrorText = SaveResult.ErrorText;
					sr.Success = false;
				}
				return sr;
			}
			else
			{
				sr.ErrorText = SnackList.GetErrorsAsHTMLString();
				return sr;
			}
		}

	}
}