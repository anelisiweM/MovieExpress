<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OnPromotionSnacks.aspx.cs" Inherits="MEWeb.Snacks.OnPromotionSnacks" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <!-- Add page specific styles and JavaScript classes below -->
  <link href="../Theme/Singular/Custom/home.css" rel="stylesheet" />
  <link href="../Theme/Singular/Custom/customstyles.css" rel="stylesheet" />
  <style>
    .Movie-border {
      border-radius: 5px;
      border: 2px solid #DEDEDE;
      padding: 15px;
      margin: 5px;
    }

    div.item {
      vertical-align: top;
      display: inline-block;
      text-align: center;
      padding-bottom: 25px;
    }

    .caption {
      display: block;
      padding-bottom: 5px;
    }
    .img{
        width:14px;
        height:10px;
    }

  </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContent" runat="server">
  <!-- Placeholder not used in this example -->
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
                          var HomeContainerTab = AssessmentsTab.AddTab("Home");
                          {
                              var Row = HomeContainerTab.Helpers.DivC("row margin0");
                              {
                                  var RowColLeft = Row.Helpers.DivC("col-md-9");
                                  {
                                      var AnotherCardDiv = RowColLeft.Helpers.DivC("ibox float-e-margins paddingBottom");
                                      {
                                          var CardTitleDiv = AnotherCardDiv.Helpers.DivC("ibox-title");
                                          {
                                              CardTitleDiv.Helpers.HTML("<i class='ffa-lg fa-fw pull-left'></i>");
                                              CardTitleDiv.Helpers.HTML().Heading5("Latest Releases");
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
                                              var RowContentDiv = ContentDiv.Helpers.DivC("row");
                                              {
                                                  var ColContentDiv = RowContentDiv.Helpers.DivC("col-md-9");
                                                  {
                                                      var SnacksDiv = ColContentDiv.Helpers.BootstrapTableFor<MELib.Promotions.SnackPromo>((c) => c.SnackPromoList, false, false, "");
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
                                                                  var SnackPriceText = SnackPrice.Helpers.Span(c =>"R"+ c.Price);
                                                                  SnackPrice.Style.Width = "80px";
                                                                  //SnackPrice.Style.TextAlign = cent;
                                                              }

                                                              //var SnackImage = FirstRow.AddColumn("Image");
                                                              //{
                                                              //    var SnackImageSrc = SnackImage.Helpers.Span("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Snack-border'/>");
                                                              //    SnackImageSrc.Helpers.HTML("<div class='movie-item'>");
                                                              //}

                                                              var SnackQty = FirstRow.AddColumn("Quantity");
                                                              {

                                                                  var SnackQuantity = SnackQty.Helpers.EditorFor(c => c.Quantity);
                                                                  //.Helpers.Span("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Snack-border'/>");

                                                              }

                                                              // Using Knockout Binding
                                                              // <img width="16px" height="16px" data-bind="attr:{src: imagePath}" />
                                                              var MoviesWatchedDiv = FirstRow.AddColumn("");
                                                              {

                                                                  MoviesWatchedDiv.Helpers.HTML("<div class='movie-item'>");
                                                                  MoviesWatchedDiv.Helpers.HTML("<img data-bind=\"attr:{src: $data.SnackImageURL()} \" class='Movie-border'/>");
                                                                  MoviesWatchedDiv.Helpers.HTML("<b><span data-bind=\"text: $data.SnackTitle() \"  class='caption'></span></b>");
                                                                  // SnacksWatchedDiv.Helpers.HTML("<span data-bind=\"text: $data.SnackTypeID() \"  class='caption'></span>");
                                                                  // MoviesWatchedDiv.Helpers.HTML("<span data-bind=\"text: $data.ReleaseDate() \"  class='caption'></span>");

                                                                  MoviesWatchedDiv.Style.Height = "10px";
                                                                  MoviesWatchedDiv.Style.Width = "10px";



                                                              }
                                                              var WatchBtn = MoviesWatchedDiv.Helpers.Button("BuySnack", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                              {
                                                                  WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Buy 3 for the price of 2 ");
                                                                  WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "BuySnack($data)");
                                                                  WatchBtn.AddClass("btn btn-primary btn-outline");
                                                              }
                                                              MoviesWatchedDiv.Helpers.HTML("</div>");
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



    var BuySnack = function (obj) {
        ViewModel.CallServerMethod('BuySnack', { SnackID: obj.SnackID(), Quantity: obj.Quantity(), Price: obj.Price(), ShowLoadingBar: true }, function (result) {
        if (result.Success) {
          window.location = result.Data;
        }
        else {
          MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
        }
      })
    }

    var FilterSnacks = function (obj) {
      ViewModel.CallServerMethod('FilterSnacks', { SnackTypeID: obj.SnackTypeID(), ResetInd: 0, ShowLoadingBar: true }, function (result) {
        if (result.Success) {
          MEHelpers.Notification("Snacks filtered successfully.", 'center', 'info', 1000);
          ViewModel.SnackList.Set(result.Data);
        }
        else {
          MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
        }
      })
    };

    var FilterReset = function (obj) {
      ViewModel.CallServerMethod('FilterSnacks', { SnackTypeID: obj.SnackTypeID(), ResetInd: 1, ShowLoadingBar: true }, function (result) {
        if (result.Success) {
          MEHelpers.Notification("Snacks reset successfully.", 'center', 'info', 1000);
          ViewModel.SnackList.Set(result.Data);
          // Set Drop Down to 'Select'
        }
        else {
          MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
        }
      })
    };


    var FilterSnackTitle = function (obj) {
      alert('test');
    };


  </script>
</asp:Content>

