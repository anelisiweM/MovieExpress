<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Basket.aspx.cs" Inherits="MEWeb.Basket.Basket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

       <link href="../Theme/Singular/Custom/home.css" rel="stylesheet" />
    <link href="../Theme/Singular/Custom/customstyles.css" rel="stylesheet" />

    <style>
    .Snack-border {
      border-radius: 5px;
      border: 2px solid #DEDEDE;
      padding: 15px;
      margin: 5px;
      height: 128px;
    width: 170px;
    }

    div.Snack-item {
      vertical-align: top;
      display: inline-block;
      text-align: center;
    }

    .caption {
      display: block;
    }


    .margin-top-10 {
      margin-top: 10px;
    }
    /* Pagination*/
  </style>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContent" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
       <%
           using (var h = this.Helpers)
           {

               var MainHDiv = h.DivC("row pad-top-10");
               {
                   var PanelContainer = MainHDiv.Helpers.DivC("col-md-12 p-n-lr");
                   {
                       var HomeContainer = PanelContainer.Helpers.DivC("tabs-container");
                       {
                           var AssessmentsTab = HomeContainer.Helpers.TabControl();
                           {
                               AssessmentsTab.Style.ClearBoth();
                               AssessmentsTab.AddClass("nav nav-tabs");
                               var HomeContainerTab = AssessmentsTab.AddTab("Basket Summary");
                               {
                                   var Row = HomeContainerTab.Helpers.DivC("row margin0");
                                   {
                                       var RowCol = Row.Helpers.DivC("col-md-12");
                                       {
                                           var ProdItemList = RowCol.Helpers.TableFor<MELib.Basket.Basket>((c) => c.BasketList, false, false);
                                           {
                                               ProdItemList.AddClass("table table-striped table-bordered table-hover");
                                               var ProdItemListRow = ProdItemList.FirstRow;
                                               {
                                                   var SnackImage = ProdItemList.FirstRow.AddColumn("");
                                                   {
                                                       SnackImage.Style.Width = "170px";

                                                       SnackImage.Helpers.Span(c => c.SnackTitle).Style.FontSize = "16px";
                                                       // SnackImage.Style.FontWeight = Bold;

                                                       var SnackImageSrc = SnackImage.Helpers.Span("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Snack-border'/>");
                                                       SnackImageSrc.Helpers.Span(a => a.SnackDescription).Style.FontSize = "16px";
                                                       //SnackImageSrc.Style.Width = "80px";
                                                       SnackImageSrc.Helpers.HTML("<div class='snack-item'>");

                                                       var ProdItemTitle = ProdItemListRow.AddColumn("Item Price");
                                                       {

                                                           ProdItemListRow.Helpers.HTMLTag("<h3> R</h3>");
                                                           //  HTML("<>R </H3>");
                                                           ProdItemTitle.Helpers.Span(a =>"R"+ a.Price).Style.FontSize = "16px";
                                                           ProdItemListRow.Helpers.HTML("<br>");

                                                           ProdItemTitle.Helpers.DivC("row");

                                                           ProdItemTitle.Style.Width = "100px";



                                                           var ProdItemQty = ProdItemListRow.AddColumn(c => c.Quantity);
                                                           {
                                                               ProdItemQty.Style.Width = "20px";
                                                           }
                                                           var ProdSubT = ProdItemListRow.AddColumn("Sub-Total");
                                                           {

                                                               ProdSubT.Helpers.Span((c => c.Price * c.Quantity));
                                                               ProdSubT.Style.Width = "80px";
                                                           }

                                                              var remove = ProdItemListRow.AddColumn(" ");
                                           {
                                               var SaveBtn = remove.Helpers.Button("Remove", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Small, Singular.Web.FontAwesomeIcon.None);
                                               {
                                                   SaveBtn.AddClass("btn-primary btn btn btn-primary");
                                                   SaveBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "Remove($data)");
                                               }
                                           }
                                                       }
                                                   }

                                               }
                                           }
                                           var SaveList1 = RowCol.Helpers.DivC("col-md-12 text-right");
                                           {
                                               var SaveBtn = SaveList1.Helpers.Button("Update Basket", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Small, Singular.Web.FontAwesomeIcon.None);
                                               {
                                                   SaveBtn.AddClass("btn-primary btn btn btn-primary");
                                                   SaveBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "SaveBasket($data)");
                                               }
                                           }
                                           //Delivery dropdown

                                           
                                           var LeftColRight = RowCol.Helpers.DivC("col-md-9");
                                      {
                                             
                                              var TransDiv = RowCol.Helpers.BootstrapTableFor<MELib.Basket.Delivery>((c) => c.DeliveryList, false, false, "");
                                              {
                                                  var FirstRow = TransDiv.FirstRow;
                                                  {
                                                     
                                       var RightColContentDiv = RowCol.Helpers.DivC("col-md-12");
                          {
                            RightColContentDiv.Helpers.LabelFor(c => ViewModel.DeliveryID);
                            var ReleaseFromDateEditor = RightColContentDiv.Helpers.EditorFor(c => ViewModel.DeliveryID);
                            ReleaseFromDateEditor.AddClass("form-control marginBottom20 ");

                           

                          }

                                                  
                                              }
                                             
                                          }
                                      }

                                           // Checkout button

                                           var SaveList = RowCol.Helpers.DivC("col-md-12 text-left");
                                           {
                                               var total = SaveList.Helpers.HTML("Total: R" + ViewModel.Total);

                                               var CheckoutBtn = SaveList.Helpers.Button("CHECKOUT", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Large, Singular.Web.FontAwesomeIcon.None);
                                               {
                                                   CheckoutBtn.AddClass("btn-primary btn btn btn-primary");
                                                   CheckoutBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "CHECKOUT($data)");
                                               }
                                           }



                                       }

                                   }

                               }
                           }
                       }
                   }
               }
           }


    %>
    <script type="text/javascript">
        // Place page specific JavaScript here or in a JS file and include in the HeadContent section
        Singular.OnPageLoad(function () {
            $("#menuItem3").addClass('active');
            $("#menuItem3 > ul").addClass('in');
        });


        var Remove = function (obj) {
            ViewModel.CallServerMethod('Remove', { SnackID: obj.SnackID(), ShowLoadingBar: true }, function (result) {
                if (result.Success) {
                    MEHelpers.Notification("Item Successfully Removed", 'center', 'success', 3000);
                }
                else {
                    MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
                }
            })
        };


        var SaveBasket = function (obj) {
            ViewModel.CallServerMethod('SaveBasket', { BasketList: ViewModel.BasketList.Serialise(), ShowLoadingBar: true }, function (result) {
                if (result.Success) {
                    MEHelpers.Notification("Successfully Saved", 'center', 'success', 3000);
                }
                else {
                    MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
                }
            })
        };

       

        var CHECKOUT = function (obj) {
            ViewModel.CallServerMethod('CHECKOUT', { Total: ViewModel.Total(), SnackID: obj.SnackID, DeliveryID: obj.DeliveryID(), ShowLoadingBar: true }, function (result) {
                if (result.Success) {
                    MEHelpers.Notification("Successfully Saved", 'center', 'success', 3000);
                    window.location="../Account/Home.aspx";
                }
                else {
                    MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
                }
            })
        };

       

        // Place page specific JavaScript here or in a JS file and include in the HeadContent section
        Singular.OnPageLoad(function () {
            $("#menuItem1").addClass('active');
            $("#menuItem1 > ul").addClass('in');
        });
        //function CHECKOUT(data) {
        //    console.log(ViewModel.ProdItemList());
        //    /*Singular.Validation.IfValid(ViewModel.Amount(), function () {*/
        //    ViewModel.CallServerMethod('CHECKOUT', { Cart: ViewModel.CartList.Serialise() }, function (result) {
        //        //Singular.AddMessage(data.Amount).Fade(2000);



        //        if (result.Success) {
        //            //window.location = "Home.aspx";
        //            Singular.AddMessage(3, 'Save', 'Saved Successfully.').Fade(2000);
        //        }
        //        else {
        //            Singular.AddMessage(1, 'Error', result.ErrorText).Fade(2000);
        //        }



        //    });
            /* });*/
        



    </script>


</asp:Content>
