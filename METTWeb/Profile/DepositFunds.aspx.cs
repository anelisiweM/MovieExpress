using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web;
using Singular.Web.Data;
using MELib.RO;
using MELib.Security;
using Singular;
using MELib.Accounts;



namespace MEWeb.Profile
{
    public partial class DepositFunds : MEPageBase<DepositFundsVM>
    {
    }
    public class DepositFundsVM : MEStatelessViewModel<DepositFundsVM>
    {
        public AccountList AccountList { get; set; }
        public MELib.Transactions.TransactionList TransactionList { get; set; }
        //public MELib.Accounts.Account Account { get; set; }
        // public String Amount { get; set; }
        public String Amount111 { get; set; } = "235";
        public DateTime ReleaseFromDate { get; set; }
        public DateTime ReleaseToDate { get; set; }



        /// <summary>
        /// Gets or sets the Movie Genre ID
        /// </summary>
        //[Singular.DataAnnotations.DropDownWeb(typeof(MELib.Accounts.AccountList), UnselectedText = "Select", ValueMember = "AccountTypeID", DisplayMember = "Type")]
        [Display(Name = "", Description = "")]
        //Singular.DataAnnotations.DropDownWeb(typeof(MELib.Accounts.AccountList), Source = Singular.DataAnnotations.DropDownWeb.SourceType.Fetch,
        //DropDownType = Singular.DataAnnotations.DropDownWeb.SelectType.NormalDropDown, LookupMember = "AccountType", DisplayMember = "AccountType", ValueMember = "AccountTypeID")]
        public int? AccountType { get; set; }
        public DepositFundsVM()
        {



        }
        protected override void Setup()
        {
            base.Setup();
            AccountList = MELib.Accounts.AccountList.GetAccountList();
            TransactionList = MELib.Transactions.TransactionList.GetTransactionListID(Singular.Security.Security.CurrentIdentity.UserID);
        }



        [WebCallable]
        public static Singular.Web.Result SaveBalance(AccountList Account)
        {

            
            var Currentuser = Singular.Security.Security.CurrentIdentity.UserID;
            // var newAccount = MELib.Accounts.Account.NewAccount();
            var newAccount = MELib.Accounts.AccountList.GetAccountListID(Singular.Security.Security.CurrentIdentity.UserID).FirstOrDefault();
            newAccount.UserID = Currentuser;

            if (newAccount.Balance < 0)
            {
                return new Singular.Web.Result() { Success = false };
            }
            else
            {
                newAccount.Balance += Account.FirstOrDefault().Balance;
              //  newAccount.AccountTypeID = 2;
                newAccount.UserID = Currentuser;
                //newAccount.IsActiveInd = true;

                var s=   newAccount.TrySave(typeof(AccountList));


                //saving transaction
                MELib.Transactions.Transaction Transaction = new MELib.Transactions.Transaction();
                MELib.Transactions.TransactionList TransactionList = new MELib.Transactions.TransactionList();

                Transaction.UserID = Currentuser;
                Transaction.TransactionTypeID = 2;
                Transaction.Amount =  Account.FirstOrDefault().Balance;
                Transaction.OrderID = 1;
                // TransactionList.Add(Transaction);
                Transaction.TrySave(typeof(MELib.Transactions.TransactionList));

                return new Singular.Web.Result() { Success = true };

            }



           

        }
    }




}