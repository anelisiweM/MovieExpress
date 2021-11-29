<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transactions.aspx.cs" Inherits="MEWeb.Profile.Transactions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <!-- Add page specific styles and JavaScript classes below -->
  <link href="../Theme/Singular/Custom/home.css" rel="stylesheet" />
  <link href="../Theme/Singular/Custom/customstyles.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContent" runat="server">
  <!-- Placeholder not used in this example -->
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <%
      using (var h = this.Helpers)
      {
          var MainContent = h.DivC("row pad-top-10");
          {
              var MainContainer = MainContent.Helpers.DivC("col-md-12 p-n-lr");
              {
                  var PageContainer = MainContainer.Helpers.DivC("tabs-container");
                  {
                      var PageTab = PageContainer.Helpers.TabControl();
                      {
                          PageTab.Style.ClearBoth();
                          PageTab.AddClass("nav nav-tabs");
                          var ContainerTab = PageTab.AddTab("Transaction History");
                          {
                              var RowContentDiv = ContainerTab.Helpers.DivC("row");
                              {

                                  var LeftColRight = RowContentDiv.Helpers.DivC("col-md-6");
                                  {
                                      var AnotherCardDiv = LeftColRight.Helpers.DivC("ibox float-e-margins paddingBottom");
                                      {
                                          var CardTitleDiv = AnotherCardDiv.Helpers.DivC("ibox-title");
                                          {
                                              CardTitleDiv.Helpers.HTML("<i class='ffa-lg fa-fw pull-left'></i>");
                                              CardTitleDiv.Helpers.HTML().Heading5("Transactions");
                                          }
                                          var TransDiv = CardTitleDiv.Helpers.BootstrapTableFor<MELib.Transactions.Transaction>((c) => c.TransactionList, false, false, "");
                                          {
                                              var FirstRow = TransDiv.FirstRow;
                                              FirstRow.Style.BackgroundColour = "#FFB577";
                                              {
                                                  var SnackTitle = FirstRow.AddColumn("Transaction Type");
                                                  {
                                                      var SnackTitleText = SnackTitle.Helpers.Span(c => c.TransactionTypeName);
                                                      SnackTitle.Style.Width = "50px";
                                                  }
                                                  var SnackDescription = FirstRow.AddColumn("Transaction Amount");
                                                  {
                                                      var SnackDescriptionText = SnackDescription.Helpers.Span(c =>"R"+ c.Amount);
                                                      SnackDescription.Style.Width = "150px";
                                                  }
                                                  //var SnackDescription1 = FirstRow.AddColumn("Transaction Date");
                                                  //{
                                                  //    var SnackDescriptionText = SnackDescription1.Helpers.Span(c => c.CreatedDate.ToString());
                                                  //    SnackDescription1.Style.Width = "150px";
                                                  //}

                                                  //var remove = FirstRow.AddColumn(" ");
                                                  //{
                                                  //    var SaveBtn = remove.Helpers.Button("View Transaction Details", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.ExtraSmall, Singular.Web.FontAwesomeIcon.None);
                                                  //    {
                                                  //        SaveBtn.AddClass("btn-primary btn btn btn-primary");
                                                  //        SaveBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "Details($data)");
                                                  //    }
                                                  //}

                                                  var hy = FirstRow.AddColumn("Transaction Date");
                                                  {
                                                      var SnackDescriptionText = hy.Helpers.Span(c => c.CreatedDate);
                                                      SnackDescription.Style.Width = "200px";
                                                  }

                                                  var Orderid = FirstRow.AddColumn("Order Number");
                                                  {
                                                      var SnackDescriptionText = Orderid.Helpers.Span(c => c.OrderID);
                                                      SnackDescription.Style.Width = "150px";
                                                  }

                                                  //             var delivery = FirstRow.AddColumn("Order ID");
                                                  //{
                                                  //    var SnackDescriptionText = delivery.Helpers.Span(c => c.de);
                                                  //    SnackDescription.Style.Width = "150px";
                                                  //}
                                              }
                                          }
                                      }

                                      var CardTitleToolsDiv = AnotherCardDiv.Helpers.DivC("ibox-tools");
                                      {
                                          var aToolsTag = CardTitleToolsDiv.Helpers.HTMLTag("a");
                                          aToolsTag.AddClass("collapse-link");
                                          {
                                              var iToolsTag = aToolsTag.Helpers.HTMLTag("i");
                                              iToolsTag.AddClass("fa fa-chevron-up");
                                          }
                                      }



                                      var ContainerTab2 = PageTab.AddTab("Transaction Order History");
                                      {
                                          var RowContentDiv1 = ContainerTab2.Helpers.DivC("row");
                                          {


                                              var ColContentDiv = RowContentDiv1.Helpers.DivC("col-md-7");
                                              {
                                                  var SnacksDiv = ColContentDiv.Helpers.BootstrapTableFor<MELib.OrderDetails.OrderDetail>((c) => c.OrderDetailList, false, false, "");
                                                  {
                                                      var FirstRow = SnacksDiv.FirstRow;
                                                      FirstRow.Style.BackgroundColour = "#FFDBC8";
                                                      {
                                                          //var SnackTitle = FirstRow.AddColumn("Order Details ID");
                                                          //{
                                                          //    var SnackTitleText = SnackTitle.Helpers.Span(c => c.OrderDetailsID);
                                                          //    SnackTitle.Style.Width = "150px";
                                                          //}
                                                          var SnackDescription = FirstRow.AddColumn("Order Number");
                                                          {
                                                              var SnackDescriptionText = SnackDescription.Helpers.Span(c => c.OrderID);
                                                              SnackDescription.Style.Width = "150px";
                                                          }

                                                          var SnackPrice1 = FirstRow.AddColumn("Delivery Type");
                                                          {
                                                              var SnackPriceText = SnackPrice1.Helpers.Span(c => c.DeliveryType);
                                                              SnackPrice1.Style.Width = "80px";
                                                              //SnackPrice.Style.TextAlign = cent;
                                                          }


                                                          var SnackID = FirstRow.AddColumn("Snack Name");


                                                          {
                                                              var SnackPriceText = SnackID.Helpers.Span(c => c.SnackTitle);

                                                              // var SaveBtn = SnackID.Helpers.Button((c => c.SnackTitle), Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.ExtraSmall, Singular.Web.FontAwesomeIcon.None);
                                                              //{
                                                              //    SaveBtn.AddClass("btn-primary btn btn btn-primary");
                                                              //    SaveBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "Details($data)");
                                                              //}
                                                          }

                                                          var date = FirstRow.AddColumn("Order Date");

                                                          {
                                                              var SnackPriceText = date.Helpers.Span(c => c.CreatedDate);
                                                              date.Style.Width = "180px";
                                                              //SnackPrice.Style.TextAlign = cent;
                                                          }

                                                          var SnackPrice = FirstRow.AddColumn("Snack Price");
                                                          {
                                                              var SnackPriceText = SnackPrice.Helpers.Span(c =>"R"+ c.ItemPrice);
                                                              SnackPrice.Style.Width = "120px";
                                                              //SnackPrice.Style.TextAlign = cent;
                                                          }
                                                          var Quantity = FirstRow.AddColumn("Product Quantity");

                                                          {
                                                              var SnackPriceText = Quantity.Helpers.Span(c => c.Quantity);
                                                              SnackPrice.Style.Width = "80px";
                                                              //SnackPrice.Style.TextAlign = cent;
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
                  }
              }
          }

      }

  %>
  <script type="text/javascript">
    // Place page specific JavaScript here or in a JS file and include in the HeadContent section
    Singular.OnPageLoad(function () {
      $("#menuItem1").addClass('active');
      $("#menuItem1 > ul").addClass('in');
    });

      var Details = function (obj) {
          console.log(obj);
          ViewModel.CallServerMethod('Details', { OrderID: obj.OrderID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  MEHelpers.Notification("Order Details Viewed Successfully", 'center', 'success', 3000);
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      };

  </script>
</asp:Content>
