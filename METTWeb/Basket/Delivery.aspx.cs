using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;
using Singular;
using Singular.Web;

namespace MEWeb.Basket
{
    public partial class Delivery : MEPageBase<DeliveryVM>
    {
    }
    public class DeliveryVM : MEStatelessViewModel<DeliveryVM>
    {
        public MELib.Snacks.SnackList SnackList { get; set; }
    
        public MELib.OrderDetails.OrderDetailList OrderDetailList { get; set; }



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
        public DeliveryVM()
        {

        }
        protected override void Setup()
        {
            base.Setup();

            BasketList = MELib.Basket.BasketList.GetBasketList();
            SnackList = MELib.Snacks.SnackList.GetSnackList();
    
            OrderDetailList = MELib.OrderDetails.OrderDetailList.GetOrderDetailList();

        }
    }
}