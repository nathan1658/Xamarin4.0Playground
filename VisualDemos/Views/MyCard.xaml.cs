using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VisualDemos.Views
{
    public partial class MyCard : Frame
    {

        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(MyCard), null);

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly BindableProperty InnerContentProperty = BindableProperty.Create("InnerContent", typeof(ContentView), typeof(MyCard), null);

        public ContentView InnerContent
        {
            get { return (ContentView)GetValue(InnerContentProperty); }
            set { SetValue(InnerContentProperty, value); }
        }


        public MyCard()
        {
            InitializeComponent();




        }

        protected override async void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                titleLabel.Text = Title;
            }

            if (propertyName == InnerContentProperty.PropertyName)
            {
                innerContent.Content = InnerContent;


            }


        }

    }
}
