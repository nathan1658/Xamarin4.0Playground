using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualDemos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Chips : ContentView
	{

        public static readonly BindableProperty BackgroundProperty = BindableProperty.Create("Background", typeof(Color), typeof(Chips),Color.FromHex("#0078D7"));

        public Color Background
        {
            get { return (Color)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }


        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(Chips), "Default");

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public Chips ()
		{
            
			InitializeComponent ();
            chipsBackground.BackgroundColor = Background;
            label.Text = Text;
		}

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == TextProperty.PropertyName)
            {
                label.Text = Text;
            }
            else if (propertyName == BackgroundProperty.PropertyName)
            {
                chipsBackground.BackgroundColor = Background;
            }

        }
    }
}