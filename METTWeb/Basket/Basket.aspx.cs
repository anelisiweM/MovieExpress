using Singular.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;

namespace MEWeb.Basket
{
    public partial class Basket : MEPageBase<BasketVM>
    { }


    public class BasketVM : MEStatelessViewModel<BasketVM>
    {
        public bool FoundUserMoviesInd { get; set; }

        public string LoggedInUserName { get; set; }

        public MELib.Basket.DeliveryList DeliveryList { get; set; }

        public MELib.Basket.BasketList BasketList { get; set; }
        public MELib.Basket.Basket Basket { get; set; }
        public MELib.OrderDetails.OrderDetailList OrderDetailList { get; set; }

        public MELib.Movies.UserMovieList UserMovieList { get; set; }

        public MELib.Accounts.AccountList UserAccountList { get; set; }
        public MELib.Accounts.Account UserAccount { get; set; }
        public MELib.Snacks.Snack SnackList { get; set; }


        public MELib.AccountTypes.AccountTypeList AccountTypeList { get; set; }
        public MELib.AccountTypes.AccountType AccountType { get; set; }

        public MELib.RO.ROUser User { get; set; }
        public MELib.RO.ROUserList UserList { get; set; }
        public Decimal Total { get; set; }

        public MELib.Order.OrderList OrderList { get; set; }
        public MELib.Order.Order Order { get; set; }

        [Singular.DataAnnotations.DropDownWeb(typeof(MELib.Basket.DeliveryList), UnselectedText = "Select", ValueMember = "DeliveryID", DisplayMember = "DeliveryType"),      
        Display(Name = "Choose a Delivery Option")]
        public int? DeliveryID { get; set; }


        //public int? Basket { get; set; }

        public BasketVM()
        {

        }

        protected override void Setup()
        {
            base.Setup();
          //  DeliveryID=

            // On page load initiate/set your data/variables and or properties here
            // Should pass in criteria for the specific user that is viewing the page, however using current identity
           // MELib.Basket.DeliveryList
            BasketList = MELib.Basket.BasketList.GetBasketListID(Singular.Security.Security.CurrentIdentity.UserID);
            Total = Math.Round(MELib.Basket.BasketList.GetBasketList().Sum(x => x.SubTotal),2);
            // DeliveryID


           
            DeliveryList = MELib.Basket.DeliveryList.GetDeliveryList();


            //foreach (MELib.Basket.Basket items in BasketList)
            //{
            //    Total += items.SubTotal;
            //}
            OrderDetailList = MELib.OrderDetails.OrderDetailList.GetOrderDetailList();
            UserMovieList = MELib.Movies.UserMovieList.GetUserMovieList();
            UserAccountList = MELib.Accounts.AccountList.GetAccountList();
            AccountTypeList = MELib.AccountTypes.AccountTypeList.GetAccountTypeList();
            UserList = MELib.RO.ROUserList.GetROUserList();

            Basket = BasketList.FirstOrDefault();

            AccountType = AccountTypeList.FirstOrDefault();
            User = UserList.FirstOrDefault();
            UserAccount = UserAccountList.FirstOrDefault();
            LoggedInUserName = Singular.Security.Security.CurrentIdentity.UserName;


        }

        [WebCallable]
        public Result SaveBasket(MELib.Basket.BasketList BasketList)
        {
            Result sr = new Result();
            if (BasketList.IsValid)
            {
                var SaveResult = BasketList.TrySave();
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
                sr.ErrorText = BasketList.GetErrorsAsHTMLString();
                return sr;
            }
        }

        [WebCallable]
        public Result Remove(int? SnackID)
        {
            Result sr = new Result();

            try
            {
                MELib.Basket.BasketList BasketList = MELib.Basket.BasketList.GetBasketListID((int)SnackID);


                var temp = BasketList.Single(c => c.SnackID == SnackID);

               MELib.Snacks.SnackList SnackList = MELib.Snacks.SnackList.GetSnackListSnackID((int)SnackID);
                var qty = SnackList.Single(c => c.SnackID == SnackID);

                qty.StockQuantity = qty.StockQuantity + temp.Quantity;

                SnackList.TrySave();

                BasketList.Remove(temp);
                BasketList.TrySave();
                sr.Success = true;

            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page : Snacks.aspx | Method: AddToBasket", $"(int SnackID");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not Remove From your basket! ";
                sr.Success = false;
            }

            return sr;

        }

        [WebCallable]
        public Result CHECKOUT(Decimal Total, int[] SnackID, int DeliveryID)
        {
            Result sr = new Result();


            try {
                MELib.OrderDetails.OrderDetail OrderDetails = MELib.OrderDetails.OrderDetail.NewOrderDetail();
               var BasketList= MELib.Basket.BasketList.GetBasketList(); 
                var Currentuser = Singular.Security.Security.CurrentIdentity.UserID;

                MELib.Order.Order Order = MELib.Order.Order.NewOrder();
                Order.OrderTotal = Total;
                var UserAccount = MELib.Accounts.AccountList.GetAccountListID(Singular.Security.Security.CurrentIdentity.UserID).FirstOrDefault();

                OrderDetails.UserID = Currentuser;

                //  if (UserAccount.Balance >= Total && SnackList.StockQuantity >= SnackList.Quantity)

                if (DeliveryID == 2)
                {
                    Total = Total + 0;
                }
                else
                if (DeliveryID == 3)
                {
                    Total = Total + 20;
                }else if(DeliveryID==0)
                {
                    sr.ErrorText = "Please Select Delivery Option to complete Checkout";
                    sr.Success = false;
                }


                if (UserAccount.Balance >= Total)
                {
                    if (Total <= 0)
                    {
                        sr.ErrorText = "BASKET IS EMPTY!!!... Please Add products to complete Checkout";
                        sr.Success = false;
                    }
                    else
                    {

                        UserAccount.Balance = UserAccount.Balance - Total;
                        UserAccount.UserID = Singular.Security.Security.CurrentIdentity.UserID;
                        UserAccount.TrySave(typeof(MELib.Accounts.AccountList));
                        var a = Order.TrySave(typeof(MELib.Order.OrderList));

                        var s = MELib.Order.OrderList.GetOrderList().LastOrDefault();



                        BasketList = MELib.Basket.BasketList.GetBasketList();
                        BasketList.ToList().ForEach(c => { c.IsActiveInd = false; });
                        BasketList.TrySave();

                        //saving transaction
                        MELib.Transactions.Transaction Transaction = new MELib.Transactions.Transaction();
                        MELib.Transactions.TransactionList TransactionList = new MELib.Transactions.TransactionList();

                        Transaction.UserID = Currentuser;
                        Transaction.TransactionTypeID = 1;
                        Transaction.Amount = Total;
                        Transaction.OrderID = s.OrderID;
                        TransactionList.Add(Transaction);
                        TransactionList.TrySave();

                        //
                        OrderDetails.OrderID = s.OrderID;
                        OrderDetails.UserID = Currentuser;
                        //getting snack list

                        for (int i = 0; i < BasketList.Count(); i++)
                        {
                            OrderDetails.SnackID = BasketList[i].SnackID;
                            OrderDetails.Quantity = BasketList[i].Quantity;
                            OrderDetails.ItemPrice = decimal.ToInt32(BasketList[i].Price);

                            OrderDetails.DeliveryID = DeliveryID;
                            OrderDetails.TrySave(typeof(MELib.OrderDetails.OrderDetailList));
                        }

                        sr.Success = true;
                    }
                }
                else
                {
                    //Message.Equals("");
                    sr.ErrorText = "INSUFFIENT FUNDS!!!... Please Deposit Funds into Your Account To complete Checkout";
                    sr.Success = false;
                }


       


            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page : Snacks.aspx | Method: AddToBasket", $"(int SnackID");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not add to your basket! ";
                sr.Success = false;
            }

            return sr;
        }
    }
}