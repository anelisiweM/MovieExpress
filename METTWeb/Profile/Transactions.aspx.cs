using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web;

namespace MEWeb.Profile
{
  public partial class Transactions : MEPageBase<TransactionsVM>
  {
  }
  public class TransactionsVM : MEStatelessViewModel<TransactionsVM>
  {
        public MELib.Transactions.TransactionList TransactionList { get; set; }
        public MELib.OrderDetails.OrderDetailList OrderDetailList { get; set; }

        public int OrderID { get; set; }

        public DateTime Date { get; set; }


        public TransactionsVM()
    {

    }
    protected override void Setup()
    {
      base.Setup();
            int CurrentUser = Singular.Security.Security.CurrentIdentity.UserID;

            TransactionList = MELib.Transactions.TransactionList.GetTransactionListID(CurrentUser);
            MELib.Transactions.TransactionList TransactionListOrder = MELib.Transactions.TransactionList.GetTransactionListOrder(CurrentUser, OrderID);

            OrderDetailList = MELib.OrderDetails.OrderDetailList.GetOrderDetailListID(OrderID, Singular.Security.Security.CurrentIdentity.UserID);

         //   Date = MELib.Transactions.TransactionList.GetTransactionListID(Singular.Security.Security.CurrentIdentity.UserID);
            OrderDetailList = MELib.OrderDetails.OrderDetailList.GetOrderDetailList();

        }

        [WebCallable]
        public Result Details(int OrderID)
        {
            Result sr = new Result();
            MELib.Transactions.TransactionList TransactionListOrder = MELib.Transactions.TransactionList.GetTransactionListOrder(Singular.Security.Security.CurrentIdentity.UserID, OrderID);

            MELib.Transactions.Transaction tt = TransactionListOrder.FirstOrDefault();


            try
            {
                // OrderID=TransactionList
                OrderID = (int)tt.OrderID;
            

          MELib.OrderDetails.OrderDetailList OrderDetailList = MELib.OrderDetails.OrderDetailList.GetOrderDetailListID(OrderID,Singular.Security.Security.CurrentIdentity.UserID);
                var temp = OrderDetailList.Single(c => c.OrderID == OrderID);
                //BasketList.Remove(temp);
                //BasketList.TrySave();

                if (tt.TransactionTypeID==2)
                {

                }

                sr.Success = true;

            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page : Basket.aspx | Method: Checkout", $"(int OrderID");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not open transaction Details! ";
                sr.Success = false;
            }

            return sr;

        }
    }
}

