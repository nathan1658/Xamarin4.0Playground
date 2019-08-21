using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace VisualDemos.Popup
{
    public partial class PopUpFrame : Rg.Plugins.Popup.Pages.PopupPage
    {


        public static readonly BindableProperty InnerContentProperty = BindableProperty.Create("InnerContent", typeof(ContentView), typeof(PopUpFrame), null);

        public ContentView InnerContent
        {
            get { return (ContentView)GetValue(InnerContentProperty); }
            set
            {
                SetValue(InnerContentProperty, value);
                innerContent.Content = value;
            }
        }

        public PopUpFrame()
        {
            InitializeComponent();
         //   this.HasSystemPadding = false;
            closeButton.Clicked += CloseButton_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            return;
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            
            this.Padding = safeAreaInset;
            safeAreaInset.Top = 0;
            secGrid.Padding = safeAreaInset;
        }

        public PopUpFrame(View view):this()
        {
            innerContent.Content = view;

        }
        private async void CloseButton_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }


        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == InnerContentProperty.PropertyName)
            {
                innerContent.Content = innerContent;
            }

        }

    }
}
