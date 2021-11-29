using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Singular.Web;
using Singular;

namespace MEWeb.Snacks
{
    public partial class OnPromotionSnacks : MEPageBase<OnPromotionSnacksVM>
    {
    }
    public class OnPromotionSnacksVM : MEStatelessViewModel<OnPromotionSnacksVM>
    {
        public MELib.Promotions.SnackPromoList SnackPromoList { get; set; }

        public MELib.Snacks.SnackList SnackList { get; set; }
       



        public MELib.Basket.BasketList BasketList { get; set; }

        public OnPromotionSnacksVM()
        {

        }
        protected override void Setup()
        {
            base.Setup();

            SnackPromoList = MELib.Promotions.SnackPromoList.GetSnackPromoList();
        }

        [WebCallable(LoggedInOnly = true)]
        public string RentSnack(int SnackID)
        {
            var url = $"../Snacks/Snack.aspx?SnackId={HttpUtility.UrlEncode(Singular.Encryption.EncryptString(SnackID.ToString()))}";
            return url;
        }

        [WebCallable]

        public Result BuySnack(int SnackID, int Quantity, double Price, decimal Total)
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
                    
                if (Quantity > 0)
              
                {
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
                 

                    if (Quantity == 3)
                    {
                        Total = ((decimal)(Price * (Quantity-1)));

                    }
                    else
                    {
                        Total = ((decimal)(Price * Quantity));
                    }


                    var a = Basket.TrySave(typeof(MELib.Basket.BasketList));




                    //foreach (MELib.Basket.Basket items in BasketList)
                    //{
                    //    var b = OrderDetails.TrySave(typeof(MELib.OrderDetails.OrderDetailList));
                    //}


                    sr.Success = true;
                }

            }
            catch (Exception e)
            {
                WebError.LogError(e, "Page : Snacks.aspx | Method: AddToBasket", $"(int SnackID, ({SnackID}");
                sr.Data = e.InnerException;
                sr.ErrorText = "Could not add to your basket! ";
                sr.Success = false;
            }


            return sr;
        }



    }
}