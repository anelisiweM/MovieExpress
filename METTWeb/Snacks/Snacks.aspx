<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Snacks.aspx.cs" Inherits="MEWeb.Snacks.Snacks" %>

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
                          var ContainerTab = PageTab.AddTab("Available Snacks");
                          {
                              var RowContentDiv = ContainerTab.Helpers.DivC("row");
                              {
                                  var ColContentDiv = RowContentDiv.Helpers.DivC("col-md-9");
                                  {
                                      var SnacksDiv = ColContentDiv.Helpers.BootstrapTableFor<MELib.Snacks.Snack>((c) => c.SnackList, false, false, "");
                                      {
                                          var FirstRow = SnacksDiv.FirstRow;
                                          {
                                              var SnackTitle = FirstRow.AddColumn("Title");
                                              {
                                                  var SnackTitleText = SnackTitle.Helpers.Span(c => c.SnackTitle);
                                                  SnackTitle.Style.Width = "150px";
                                              }
                                              var SnackDescription = FirstRow.AddColumn("Description");
                                              {
                                                  var SnackDescriptionText = SnackDescription.Helpers.Span(c => c.SnackDescription);
                                                  SnackDescription.Style.Width = "150px";
                                              }

                                              var SnackPrice = FirstRow.AddColumn("Price");
                                              {
                                                  var SnackPriceText = SnackPrice.Helpers.Span(c => "R"+ c.Price);
                                                  SnackPrice.Style.Width = "80px";
                                                  //SnackPrice.Style.TextAlign = cent;
                                              }

                                              var SnackImage = FirstRow.AddColumn("Image");
                                              {
                                                  var SnackImageSrc = SnackImage.Helpers.Span("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Snack-border'/>");
                                                  SnackImageSrc.Helpers.HTML("<div class='movie-item'>");
                                              }

                                              var SnackQty = FirstRow.AddColumn("Quantity");
                                              {

                                                  var SnackQuantity = SnackQty.Helpers.EditorFor(c => c.Quantity);
                                                  //.Helpers.Span("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Snack-border'/>");

                                              }

                                              //var SnackSubT = FirstRow.AddColumn("Quantity");
                                              {
                                                  // var SnackSubTotal = SnackSubT.Helpers.
                                                  //.Helpers.Span("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Snack-border'/>");

                                              }


                                              var SnackAction = FirstRow.AddColumn("");
                                              {
                                                  // Watch Snack
                                                  //var WatchBtn = SnackAction.Helpers.Button("AddToCart", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                  //{
                                                  //    //WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Buy Now @ R " + c.Price);
                                                  //    WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "AddToCart($data)");
                                                  //    WatchBtn.AddClass("btn btn-primary btn-outline");
                                                  //}

                                                  SnackAction.Helpers.HTML("Availability: ");
                                                  SnackAction.Helpers.Span(c => c.StockQuantity);
                                                  var BasketBtn = SnackAction.Helpers.Button("Add to Basket", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                  {
                                                      //WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Buy Now @ R " + c.Price);
                                                      BasketBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "AddToBasket($data)");
                                                      BasketBtn.AddClass("btn btn-primary btn-outline");
                                                  }
                                              }
                                          }
                                      }
                                  }
                                  var RowColRight = RowContentDiv.Helpers.DivC("col-md-3");
                                  {

                                      var AnotherCardDiv = RowColRight.Helpers.DivC("ibox float-e-margins paddingBottom");
                                      {
                                          var CardTitleDiv = AnotherCardDiv.Helpers.DivC("ibox-title");
                                          {
                                              CardTitleDiv.Helpers.HTML("<i class='ffa-lg fa-fw pull-left'></i>");
                                              CardTitleDiv.Helpers.HTML().Heading5("Filter Criteria");
                                          }
                                          var CardTitleToolsDiv = CardTitleDiv.Helpers.DivC("ibox-tools");
                                          {
                                              var aToolsTag = CardTitleToolsDiv.Helpers.HTMLTag("a");
                                              aToolsTag.AddClass("collapse-link");
                                              {
                                                  var iToolsTag = aToolsTag.Helpers.HTMLTag("i");
                                                  iToolsTag.AddClass("fa fa-chevron-up");
                                              }
                                          }
                                          var ContentDiv = AnotherCardDiv.Helpers.DivC("ibox-content");
                                          {
                                              var RightRowContentDiv = ContentDiv.Helpers.DivC("row");
                                              {
                                                  var RightColContentDiv = RightRowContentDiv.Helpers.DivC("col-md-12");
                                                  {
                                                      RightColContentDiv.Helpers.LabelFor(c => ViewModel.SnackTypeID);
                                                      var ReleaseFromDateEditor = RightColContentDiv.Helpers.EditorFor(c => ViewModel.SnackTypeID);
                                                      ReleaseFromDateEditor.AddClass("form-control marginBottom20 ");

                                                      var FilterBtn = RightColContentDiv.Helpers.Button("Apply Filter", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                      {
                                                          FilterBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "FilterSnacks($data)");
                                                          FilterBtn.AddClass("btn btn-primary btn-outline");
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

      //basket

      // ViewModel.CallServerMethod('AddToBasket', { SnackID: obj.SnackID(), Price: obj.Price(), Quantity: obj.Quantity(), SnackDescription: obj.SnackDescription, SnackTitle: obj.SnackTitle, ShowLoadingBar: true }, function (result) {


      var AddToBasket = function (obj) {
          ViewModel.CallServerMethod('AddToBasket', { SnackID: obj.SnackID(), Quantity: obj.Quantity(), Price: obj.Price(), Total: obj.Total, ShowLoadingBar: true }, function (result) {
              if (result.Success) {


                  MEHelpers.Notification("Added to Basket Sucessfully. ", 'center', 'sucess', 2500);
                  window.location = ViewModel.SnackList.set(result.Data);
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      }
      //end basket

      var AddToCart = function (obj) {
          ViewModel.CallServerMethod('AddToCart', { SnackID: obj.SnackID(), Price: obj.Price(), Quantity: obj.Quantity(),ShowLoadingBar: true }, function (result) {
              if (result.Success) {


                    MEHelpers.Notification("Added to Cart Sucessfully. ", 'center', 'sucess', 2500);
                  window.location = ViewModel.SnackList.set(result.Data);
        }
       else {
         MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
       }
      })
    }


      function AddToCarTT(obj) {
          ViewModel.CallServerMethod('AddToCarTT', { SnackID: obj.SnackID(), Price: obj.Price(), Quantity: obj.Quantity(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  console.log(ViewModel.SnackList());
                  Singular.AddMessage(3, 'Saved', 'Order has been saved successfully.').Fade(5000);
              }
              else {
                  Singular.AddMessage(1, 'Error', result.ErrorText).Fade(2000);
              }
          });
      }

      //Cart
    //  var AddToCart = function (obj) {
    //      ViewModel.CallServerMethod('AddToCart', { SnackID: obj.SnackID(), Price: obj.Price(), ShowLoadingBar: true }, function (result) {
    //          if (result.Success) {


    //                  MEHelpers.Notification("Added to Cart Sucessfully. ", 'center', 'sucess', 2500);
    //      window.location = result.Data;
    //    }
    //    else {
    //      MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
    //    }
    //  })
    //}

    var WatchSnack = function (obj) {

      MEHelpers.QuestionDialogYesNo("Are you sure you would like to watch this Snack?", 'center',
        function () { // Yes
          ViewModel.CallServerMethod('WatchSnack', { SnackID: obj.SnackID(), ShowLoadingBar: true }, function (result) {
            if (result.Success) {
              MEHelpers.Notification("Item deleted successfully.", 'center', 'success', 5000);
            }
            else {
              MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
            }
          })
        },
        function () { // No
        })
    };

      var FilterSnacks = function (obj) {
          ViewModel.CallServerMethod('FilterSnacks', { SnackTypeID: obj.SnackTypeID(), ShowLoadingBar: true }, function (result) {
        if (result.Success) {
          MEHelpers.Notification("Snacks filtered successfully.", 'center', 'info', 1000);
          ViewModel.SnackList.Set(result.Data);
        }
        else {
          MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
        }
      })
      };

   

  </script>
</asp:Content>
