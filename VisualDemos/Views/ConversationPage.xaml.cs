using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using VisualDemos.Popup;
using Xamarin.Forms;

namespace VisualDemos.Views
{
    public partial class ConversationPage : ContentPage
    {

        string htmlString = @"<!DOCTYPE html>
<html>
<head>
<style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
</style>
</head>
<body>


<table>
  <tr>
    <th>Company</th>
    <th>Contact</th>
    <th>Country</th>
  </tr>
  <tr>
    <td>Alfreds Futterkiste</td>
    <td>Maria Anders</td>
    <td>Germany</td>
  </tr>
  <tr>
    <td>Centro comercial Moctezuma</td>
    <td>Francisco Chang</td>
    <td>Mexico</td>
  </tr>
  <tr>
    <td>Ernst Handel</td>
    <td>Roland Mendel</td>
    <td>Austria</td>
  </tr>
  <tr>
    <td>Island Trading</td>
    <td>Helen Bennett</td>
    <td>UK</td>
  </tr>
  <tr>
    <td>Laughing Bacchus Winecellars</td>
    <td>Yoshi Tannamuri</td>
    <td>Canada</td>
  </tr>
  <tr>
    <td>Magazzini Alimentari Riuniti</td>
    <td>Giovanni Rovelli</td>
    <td>Italy</td>
  </tr>
</table>

</body>
</html>
";

        public ConversationPage()
        {
            InitializeComponent();

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = htmlString;


            webView.Source = htmlSource;

            ExpandButton.Clicked += ExpandButton_Clicked;
            chatButton.Clicked += ChatButton_Clicked;
        }

        private void ChatButton_Clicked(object sender, EventArgs e)
        {
            var lbl = new Label { Text = "ChatUi" };
            lbl.HorizontalOptions = lbl.VerticalOptions = LayoutOptions.Center;
            var popUp = new PopUpFrame(lbl);
            PopupNavigation.Instance.PushAsync(popUp);
        }

        private void ExpandButton_Clicked(object sender, EventArgs e)
        {

            var tmpWebView = new WebView();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = htmlString;


            tmpWebView.Source = htmlSource;
            var popUp = new PopUpFrame(tmpWebView);
                       

            PopupNavigation.Instance.PushAsync(popUp);
        }
    }
}
