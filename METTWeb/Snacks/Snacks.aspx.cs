using System;
using System.ComponentModel.DataAnnotations;
using System.Web;
using Singular.Web;


namespace MEWeb.Snacks
{
    public partial class Snacks : MEPageBase<SnacksVM>
    {
    }
    public class SnacksVM : MEStatelessViewModel<SnacksVM>
    {
        public MELib.Snacks.SnackList SnackList { get; set; }
   

    

        public MELib.Basket.BasketList BasketList { get; set; }

        // Filter Criteria
        public DateTime ReleaseFromDate { get; set; }
        public DateTime ReleaseToDate { get; set; }

        /// <summary>
        /// Gets or sets the Snack Type ID
        /// </summary>
        [Singular.DataAnnotations.DropDownWeb(typeof(MELib.Snacks.SnackTypeList), UnselectedText = "Select", ValueMember = "SnackTypeID", DisplayMember = "Type")]
        [Display(Name = "Type")]

        public int? SnackTypeID { get; set; }
        public SnacksVM()
        {

        }
        protected override void Setup()
        {
            base.Setup();
           

            BasketList = MELib.Basket.BasketList.GetBasketList();
            SnackList = MELib.Snacks.SnackList.GetSnackList();
        
        }

        [WebCallable(LoggedInOnly = true)]
        public string RentSnack(int SnackID)
        {
            var url = $"../Snacks/Snack.aspx?SnackId={HttpUtility.UrlEncode(Singular.Encryption.EncryptString(SnackID.ToString()))}";
            return url;
        }

        [WebCallable]

        public  Result AddToBasket(int SnackID, int Quantity,double Price, decimal Total)
        {
            Result sr = new Result();

            try
            {

           

                var Currentuser = Singular.Security.Security.CurrentIdentity.UserID;

                MELib.Snacks.SnackList ProdToSave = MELib.Snacks.SnackList.GetSnackListSnackID(SnackID);
                MELib.Snacks.Snack ProdToAddToBasket = ProdToSave.GetItem(SnackID);
                MELib.Basket.Basket Basket = MELib.Basket.Basket.NewBasket();



                if (Quantity <= 0)
                {
                    sr.ErrorText = "Please specify product Quantity to be able to add it to Basket ";
                }
                else
                   
                if (Quantity > 0 )
                {
                    if (SnackID == Basket.SnackID)
                    {

                        sr.Success = false;
                    }
                    else
                    {
                        var b = Basket.TrySave(typeof(MELib.Basket.BasketList));
                    }


                   


                    //getting the order ic
                    // OrderDetails.OrderID = MELib.Order.OrderList.GetOrderList();


                    Basket.UserID = Currentuser;


                    Basket.SnackID = ProdToAddToBasket.SnackID;
                    //  OrderDetails.SnackID = ProdToAddToBasket.SnackID;

                    Basket.SnackImageURL = ProdToAddToBasket.SnackImageURL;
                    Basket.SnackTitle = ProdToAddToBasket.SnackTitle;
                    Basket.SnackDescription = ProdToAddToBasket.SnackDescription;

                    Basket.Price = ProdToAddToBasket.Price;
                    //  OrderDetails.ItemPrice = ProdToAddToBasket.Price;

                    Basket.Quantity = Quantity;
                    // OrderDetails.Quantity = ProdToAddToBasket.Quantity;



                    if (ProdToAddToBasket.StockQuantity >= Quantity)
                    {
                        ProdToAddToBasket.StockQuantity = ProdToAddToBasket.StockQuantity - Quantity;
                        //  ProdToAddToBasket.SnackID = Basket.SnackID;
                        var c = ProdToAddToBasket.TrySave(typeof(MELib.Snacks.SnackList));
                    }
                    else
                if (ProdToAddToBasket.StockQuantity < Quantity)
                    {
                        sr.ErrorText = "Insuffient Quantity! ";
                    }

                    Basket.IsActiveInd = true;
                    Total = ((decimal)(Price * Quantity));


                    var a = Basket.TrySave(typeof(MELib.Basket.BasketList));




                    //foreach (MELib.Basket.Basket items in BasketList)
                    //{
                    //    var b = OrderDetails.TrySave(typeof(MELib.OrderDetails.OrderDetailList));
                    //}


                    sr.Success = true;
                }

            }
            catch(Exception e)
            {
                WebError.LogError(e, "Page : Snacks.aspx | Method: AddToBasket", $"(int SnackID, ({SnackID}");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not add to your basket! ";
                sr.Success = false;
            }


            return sr;
        }

        [WebCallable]
        public Result FilterSnacks(int SnackTypeID)
        {
            Result sr = new Result();
            try
            {
                sr.Data = MELib.Snacks.SnackList.GetSnackListSnackID(SnackTypeID);
                sr.Success = true;
            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page: LatestReleases.aspx | Method: FilterSnacks", $"(int SnackTypeID, ({SnackTypeID})");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not filter Snacks by category.";
                sr.Success = false;
            }
            return sr;
        }

    }
}

