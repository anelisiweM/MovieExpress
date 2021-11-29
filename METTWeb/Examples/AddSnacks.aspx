<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddSnacks.aspx.cs" Inherits="MEWeb.Examples.AddSnacks" %>

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
                          var HomeContainerTab = AssessmentsTab.AddTab("Editable Table");
                          {
                              var Row = HomeContainerTab.Helpers.DivC("row margin0");
                              {
                                  var RowCol = Row.Helpers.DivC("col-md-12");
                                  {
                                      RowCol.Helpers.HTML().Heading2("Editable Table");
                                      RowCol.Helpers.HTMLTag("p").HTML = "Create a basic table by generating your classes using the CSLA Extension.";
                                      RowCol.Helpers.HTML("<p>You can alter the stored procedure to retrieve the required information (e.g. Genre Name/Description instead of the foreign key/id).</p>");
                                      RowCol.Helpers.HTML("<p>Should you have a dropdown data annotation on one of the properties on your object, the table will automatically change the field to a drop down list. Changing the TableFor properties allows for adding new items/removing of items from your object list. All that is left to do is to save the list.</p><br>");
                                      RowCol.Helpers.HTML("<p>In order to Add, Update or Delete items from the list, write a JavaScript function that in return calls a web callable method to save the list on the ViewModel.</p>");
                                      RowCol.Helpers.HTML("<pre><code>var SaveResult = SnackList.TrySave();</code></pre><br>");
                                      RowCol.Helpers.HTML().Heading3("Example");


                                      var SnackList = RowCol.Helpers.TableFor<MELib.Snacks.Snack>((c) => c.SnackList, true, true);
                                      {
                                          SnackList.AddClass("table table-striped table-bordered table-hover");
                                          var SnackListRow = SnackList.FirstRow;
                                          {
                                              var SnackTitle = SnackListRow.AddColumn(c => c.SnackTitle);
                                              {
                                                  SnackTitle.Style.Width = "200px";
                                              }
                                              var SnackGenreID = SnackListRow.AddColumn(c => c.SnackTypeID);
                                              {
                                                  SnackGenreID.Style.Width = "50px";
                                              }
                                              var SnackDescription = SnackListRow.AddColumn(c => c.SnackDescription);
                                              {
                                                  SnackDescription.Style.Width = "100px";
                                              }
                                              var SnackPrice = SnackListRow.AddColumn(c => c.Price);
                                                    {
                                                    SnackPrice.Style.Width = "100px";
                                                    }


                                              var SnackReleaseDate = SnackListRow.AddColumn(c => c.ReleaseDate);
                                              {
                                                  SnackReleaseDate.Style.Width = "175px";
                                              }
                                          }
                                      }

                                      var SaveList = RowCol.Helpers.DivC("col-md-12 text-right");
                                      {
                                          var SaveBtn = SaveList.Helpers.Button("Save", Singular.Web.ButtonMainStyle.NoStyle, Singular.Web.ButtonSize.Normal, Singular.Web.FontAwesomeIcon.None);
                                          {
                                              SaveBtn.AddClass("btn-primary btn btn btn-primary");
                                              SaveBtn.AddBinding(Singular.Web.KnockoutBindingString.click, "SaveSnacks($data)");
                                          }
                                      }

                                  }
                              }
                              var BottomRow = HomeContainerTab.Helpers.DivC("row margin0");
                              {
                                  var BottomRowCol = BottomRow.Helpers.DivC("col-md-12");
                                  {
                                      BottomRowCol.Helpers.HTML("<p>Ensure your 'Delete' 'stored procedure is doing a 'soft' delete, bu replacing the DELETE script with an UPDATE script.</p>");
                                      BottomRowCol.Helpers.HTML("<pre><code>UPDATE Snacks SET IsActiveInd = 0 WHERE SnackID = @SnackID</code></pre><br>");
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

    var /*SaveSnacks*/ = function (obj) {
        ViewModel.CallServerMethod('SaveSnacksList', { SnackList: ViewModel.SnackList.Serialise(), ShowLoadingBar: true }, function (result) {
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
