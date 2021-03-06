<%@ Page Title="Popcorn" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomTables.aspx.cs" Inherits="MEWeb.Examples.DataTables" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
  <script type="text/javascript" src="../Scripts/JSLINQ.js"></script>
  <link href="../Theme/Singular/Custom/home.css" rel="stylesheet" />
  <link href="../Theme/Singular/Custom/customstyles.css" rel="stylesheet" />
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
                              var HomeContainerTab = AssessmentsTab.AddTab("Movies");
                              {
                                  var Row = HomeContainerTab.Helpers.DivC("row margin0");
                                  {
                                      var RowCol = Row.Helpers.DivC("col-md-12");
                                      {
                                          RowCol.Helpers.HTML().Heading2("Custom Tables");
                                          RowCol.Helpers.HTMLTag("p").HTML = "An example below.";

                                          var MovieList = RowCol.Helpers.BootstrapTableFor<MELib.Movies.Movie>((c) => c.MovieList, false, false, "");
                                          {
                                              var MovieListRow = MovieList.FirstRow;
                                              {
                                                  var MovieTitle = MovieListRow.AddColumn("Title");
                                                  {
                                                      MovieTitle.Style.Width = "200px";
                                                      var MovieTitleText = MovieTitle.Helpers.Span(c => c.MovieTitle);
                                                  }
                                                  var MovieGenre = MovieListRow.AddColumn("Genre");
                                                  {
                                                      var MovieGenreText = MovieGenre.Helpers.Span(c => c.MovieGenreID);
                                                  }
                                                  var MovieDescription = MovieListRow.AddColumn("Description");
                                                  {
                                                      var MovieDescriptionText = MovieDescription.Helpers.Span(c => c.MovieDescription);
                                                      {
                                                          // MovieDescription.Style.Width = "200px";
                                                      }
                                                  }
                                                  var Actions = MovieListRow.AddColumn("Actions");
                                                  {
                                                      Actions.Style.Width = "300px";

                                                      // Add Buttons
                                                      var btnAdd = Actions.Helpers.Button("Add", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                      {
                                                          btnAdd.AddClass("btn btn-primary btn-outline");
                                                          btnAdd.AddBinding(Singular.Web.KnockoutBindingString.click, "Add($data)");
                                                          btnAdd.Style.BackgroundColour = "grey";

                                                       //   btnAdd.Style.Padding([top = "0px"],[string right = "0"], [string bottom = "0"], [string left = "5px"]};
                                                  }

                                                  var btnView = Actions.Helpers.Button("View", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                  {
                                                      btnView.AddClass("btn btn-primary btn-outline");
                                                      btnView.AddBinding(Singular.Web.KnockoutBindingString.click, "GenerateInterventionRpt($data)");
                                                  }
                                                  var btnDelete = Actions.Helpers.Button("Delete", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                  {
                                                      btnDelete.AddClass("btn btn-primary btn-outline");
                                                      btnDelete.AddBinding(Singular.Web.KnockoutBindingString.click, "GenerateInterventionRpt($data)");
                                                  }
                                              }
                                          }
                                      }
                                  }
                              }
                          }


                          var HomeContainerTab2 = AssessmentsTab.AddTab("Snacks");
                          {
                              var Row = HomeContainerTab2.Helpers.DivC("row margin0");
                              {
                                  var RowCol = Row.Helpers.DivC("col-md-12");
                                  {
                                      RowCol.Helpers.HTML().Heading2("Custom Tables");
                                      RowCol.Helpers.HTMLTag("p").HTML = "An example below.";

                                      var SnackList = RowCol.Helpers.BootstrapTableFor<MELib.Snacks.Snack>((c) => c.SnackList, false, false, "");
                                      {
                                          var SnackListRow = SnackList.FirstRow;
                                          {
                                              var SnackTitle = SnackListRow.AddColumn("Title");
                                              {
                                                  SnackTitle.Style.Width = "200px";
                                                  var SnackTitleText = SnackTitle.Helpers.Span(c => c.SnackTitle);
                                              }
                                              var SnackType = SnackListRow.AddColumn("Genre");
                                              {
                                                  var SnackTitleText = SnackType.Helpers.Span(c => c.SnackTypeID);
                                              }
                                              var SnackDescription = SnackListRow.AddColumn("Description");
                                              {
                                                  var SnackDescriptionText = SnackDescription.Helpers.Span(c => c.SnackDescription);
                                              }
                                              var Actions = SnackListRow.AddColumn("Actions");
                                              {
                                                  Actions.Style.Width = "150px";
                                                  // Add Buttons
                                                  var btnView = Actions.Helpers.Button("View", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                  {
                                                      btnView.AddClass("btn btn-primary btn-outline");
                                                      btnView.AddBinding(Singular.Web.KnockoutBindingString.click, "GenerateInterventionRpt($data)");
                                                  }
                                                  var btnDelete = Actions.Helpers.Button("Delete", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                                  {
                                                      btnDelete.AddClass("btn btn-primary btn-outline");
                                                      btnDelete.AddBinding(Singular.Web.KnockoutBindingString.click, "GenerateInterventionRpt($data)");
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
    Singular.OnPageLoad(function () {
      $("#menuItem5").addClass("active");
      $("#menuItem5 > ul").addClass("in");
    });

      var Add = function (obj) {
          ViewModel.CallServerMethod('SaveMoviesList', { MovieList: ViewModel.MovieList.Serialise(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  MEHelpers.Notification("Successfully Saved", 'center', 'success', 3000);
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          });
      }

  </script>

</asp:Content>
