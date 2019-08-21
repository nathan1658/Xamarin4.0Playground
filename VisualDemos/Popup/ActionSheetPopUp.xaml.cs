using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace VisualDemos.Popup
{
    public partial class ActionSheetPopUp : Rg.Plugins.Popup.Pages.PopupPage
    {
        public ActionSheetPopUp()
        {
            InitializeComponent();
            this.HasSystemPadding = false;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            safeAreaInset.Top = 0;
            buttonStack.Padding = safeAreaInset;
            
        }
    }
}
