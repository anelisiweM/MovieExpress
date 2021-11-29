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

	public partial class AddSnacks : MEPageBase<AddSnacksVM>
	{

	}
	public class AddSnacksVM : MEStatelessViewModel<AddSnacksVM>
	{
		//public MELib.Snackss.SnacksList SnacksList { get; set; }
		public MELib.Snacks.SnackList SnackList { get; set; }

		public AddSnacksVM()
		{

		}

		protected override void Setup()
		{
			base.Setup();
			SnackList = MELib.Snacks.SnackList.GetSnackList();
		}


		[WebCallable]
		public Result SaveSnacksList(MELib.Snacks.SnackList SnacksList)
		{
			Result sr = new Result();
			if (SnacksList.IsValid)
			{
				var SaveResult = SnacksList.TrySave();
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
				sr.ErrorText = SnacksList.GetErrorsAsHTMLString();
				return sr;
			}
		}

	}
}