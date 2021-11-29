<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Movies.aspx.cs" Inherits="MEWeb.Movies.Movies" %>

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
              var ContainerTab = PageTab.AddTab("Available Movies");
              {
                var RowContentDiv = ContainerTab.Helpers.DivC("row");
                {
                  var ColContentDiv = RowContentDiv.Helpers.DivC("col-md-9");
                  {
                    var MoviesDiv = ColContentDiv.Helpers.BootstrapTableFor<MELib.Movies.Movie>((c) => c.MovieList, false, false, "");
                    {
                      var FirstRow = MoviesDiv.FirstRow;
                      {
                        var MovieTitle = FirstRow.AddColumn("Title");
                        {
                          var MovieTitleText = MovieTitle.Helpers.Span(c => c.MovieTitle);
                          MovieTitle.Style.Width = "250px";
                        }
                        var MovieDescription = FirstRow.AddColumn("Description");
                        {
                          var MovieDescriptionText = MovieDescription.Helpers.Span(c => c.MovieDescription);
                        }
                        var MovieAction = FirstRow.AddColumn("");
                        {
                          // Watch Movie
                          var WatchBtn = MovieAction.Helpers.Button("Rent Now", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                          {
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Rent Now @ R " + c.Price);
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "RentMovie($data)");
                            WatchBtn.AddClass("btn btn-primary btn-outline");
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
                            RightColContentDiv.Helpers.LabelFor(c => ViewModel.MovieGenreID);
                            var ReleaseFromDateEditor = RightColContentDiv.Helpers.EditorFor(c => ViewModel.MovieGenreID);
                            ReleaseFromDateEditor.AddClass("form-control marginBottom20 ");

                            var FilterBtn = RightColContentDiv.Helpers.Button("Apply Filter", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                            {
                              FilterBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "FilterMovies($data)");
                              FilterBtn.AddClass("btn btn-primary btn-outline");
                            }

                          }
                        }
                      }
                    }
                  }
                }
              }

                             var ContainerTab2 = PageTab.AddTab("Available Tv Shows");
              {
                var RowContentDiv2 = ContainerTab2.Helpers.DivC("row");
                {
                  var ColContentDiv2 = RowContentDiv2.Helpers.DivC("col-md-9");
                  {
                    var TvshowDiv = ColContentDiv2.Helpers.BootstrapTableFor<MELib.TvShows.TvShow>((c) => c.TVShowsList, false, false, "");
                    {
                      var FirstRow = TvshowDiv.FirstRow;
                      {
                        var MovieTitle = FirstRow.AddColumn("Title");
                        {
                          var MovieTitleText = MovieTitle.Helpers.Span(c => c.TvShowTitle);
                          MovieTitle.Style.Width = "250px";
                        }
                        var MovieDescription = FirstRow.AddColumn("Description");
                        {
                          var MovieDescriptionText = MovieDescription.Helpers.Span(c => c.TvShowDescription);
                        }
                        var MovieAction = FirstRow.AddColumn("");
                        {
                          // Watch Movie
                          var WatchBtn = MovieAction.Helpers.Button("Rent Now", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                          {
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Rent Now @ R " + c.Price);
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "RentMovieT($data)");
                            WatchBtn.AddClass("btn btn-primary btn-outline");
                          }
                        }
                      }
                    }
                  }
                  var RowColRight = RowContentDiv2.Helpers.DivC("col-md-3");
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
                            RightColContentDiv.Helpers.LabelFor(c => ViewModel.MovieGenreID);
                            var ReleaseFromDateEditor = RightColContentDiv.Helpers.EditorFor(c => ViewModel.MovieGenreID);
                            ReleaseFromDateEditor.AddClass("form-control marginBottom20 ");

                            var FilterBtn = RightColContentDiv.Helpers.Button("Apply Filter", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                            {
                              FilterBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "FilterTvShows($data)");
                              FilterBtn.AddClass("btn btn-primary btn-outline");
                            }

                          }
                        }
                      }
                    }
                  }
                }
              }

                                           var ContainerTab4 = PageTab.AddTab("Available Sport Shows");
              {
                var RowContentDiv4 = ContainerTab4.Helpers.DivC("row");
                {
                  var ColContentDiv4 = RowContentDiv4.Helpers.DivC("col-md-9");
                  {
                    var TvshowDiv = ColContentDiv4.Helpers.BootstrapTableFor<MELib.SportShows.SportShow>((c) => c.SportShowsList, false, false, "");
                    {
                      var FirstRow = TvshowDiv.FirstRow;
                      {
                        var MovieTitle = FirstRow.AddColumn("Title");
                        {
                          var MovieTitleText = MovieTitle.Helpers.Span(c => c.SportShowTitle);
                          MovieTitle.Style.Width = "250px";
                        }
                        var MovieDescription = FirstRow.AddColumn("Description");
                        {
                          var MovieDescriptionText = MovieDescription.Helpers.Span(c => c.SportShowDescription);
                        }
                        var MovieAction = FirstRow.AddColumn("");
                        {
                          // Watch Movie
                          var WatchBtn = MovieAction.Helpers.Button("Rent Now", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                          {
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Rent Now @ R " + c.Price);
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "RentMovieS($data)");
                            WatchBtn.AddClass("btn btn-primary btn-outline");
                          }
                        }
                      }
                    }
                  }
                  var RowColRight = RowContentDiv4.Helpers.DivC("col-md-3");
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
                            RightColContentDiv.Helpers.LabelFor(c => ViewModel.MovieGenreID);
                            var ReleaseFromDateEditor = RightColContentDiv.Helpers.EditorFor(c => ViewModel.MovieGenreID);
                            ReleaseFromDateEditor.AddClass("form-control marginBottom20 ");

                            var FilterBtn = RightColContentDiv.Helpers.Button("Apply Filter", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                            {
                              FilterBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "FilterMovies($data)");
                              FilterBtn.AddClass("btn btn-primary btn-outline");
                            }

                          }
                        }
                      }
                    }
                  }
                }
              }

                                           var ContainerTab6 = PageTab.AddTab("Available Kids Shows");
              {
                var RowContentDiv6 = ContainerTab6.Helpers.DivC("row");
                {
                  var ColContentDiv6 = RowContentDiv6.Helpers.DivC("col-md-9");
                  {
                    var TvshowDiv6 = ColContentDiv6.Helpers.BootstrapTableFor<MELib.KidsShows.KidsShow>((c) => c.KidsShowsList, false, false, "");
                    {
                      var FirstRow = TvshowDiv6.FirstRow;
                      {
                        var MovieTitle = FirstRow.AddColumn("Title");
                        {
                          var MovieTitleText = MovieTitle.Helpers.Span(c => c.KidTitle);
                          MovieTitle.Style.Width = "250px";
                        }
                        var MovieDescription = FirstRow.AddColumn("Description");
                        {
                          var MovieDescriptionText = MovieDescription.Helpers.Span(c => c.KidDescription);
                        }
                        var MovieAction = FirstRow.AddColumn("");
                        {
                          // Watch Movie
                          var WatchBtn = MovieAction.Helpers.Button("Rent Now", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                          {
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.text, c => "Rent Now @ R " + c.Price);
                            WatchBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "RentMovieK($data)");
                            WatchBtn.AddClass("btn btn-primary btn-outline");
                          }
                        }
                      }
                    }
                  }
                  var RowColRight = RowContentDiv6.Helpers.DivC("col-md-3");
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
                            RightColContentDiv.Helpers.LabelFor(c => ViewModel.MovieGenreID);
                            var ReleaseFromDateEditor = RightColContentDiv.Helpers.EditorFor(c => ViewModel.MovieGenreID);
                            ReleaseFromDateEditor.AddClass("form-control marginBottom20 ");

                            var FilterBtn = RightColContentDiv.Helpers.Button("Apply Filter", Singular.Web.ButtonMainStyle.Primary, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                            {
                              FilterBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "FilterMovies($data)");
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

      var RentMovie = function (obj) {
          ViewModel.CallServerMethod('RentMovie', { MovieID: obj.MovieID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  MEHelpers.Notification("Rented Successfully. ", 'center', 'success', 1000);
                  window.location = ViewModel.MovieList.Set(result.Data);
                  //window.location = result.Data;
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      }

      var RentMovieK = function (obj) {
          ViewModel.CallServerMethod('RentMovie', { KidID: obj.KidID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  window.location = result.Data;
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      }

      var RentMovieT = function (obj) {
          ViewModel.CallServerMethod('RentMovie', { TvShowID: obj.TvShowID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  window.location = result.Data;
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      }

      var RentMovieS = function (obj) {
          ViewModel.CallServerMethod('RentMovie', { SportShowID: obj.SportShowID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  window.location = result.Data;
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      }

      var WatchMovie = function (obj) {

          MEHelpers.QuestionDialogYesNo("Are you sure you would like to watch this movie?", 'center',
              function () { // Yes
                  ViewModel.CallServerMethod('WatchMovie', { MovieID: obj.MovieID(), ShowLoadingBar: true }, function (result) {
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

      var FilterMovies = function (obj) {
          // alert('Movie Genre ID ' + obj.MovieGenreID());

          ViewModel.CallServerMethod('FilterMovies', { MovieGenreID: obj.MovieGenreID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  MEHelpers.Notification("Movies filtered successfully.", 'center', 'info', 1000);
                  ViewModel.MovieList.Set(result.Data);
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      };

      var FilterTvShows = function (obj) {
          // alert('Movie Genre ID ' + obj.MovieGenreID());

          ViewModel.CallServerMethod('FilterTvShows', { MovieGenreID: obj.MovieGenreID(), ShowLoadingBar: true }, function (result) {
              if (result.Success) {
                  MEHelpers.Notification("Tv Shows filtered successfully.", 'center', 'info', 1000);
                  ViewModel.TvShowList.Set(result.Data);
              }
              else {
                  MEHelpers.Notification(result.ErrorText, 'center', 'warning', 5000);
              }
          })
      };

  </script>
</asp:Content>
