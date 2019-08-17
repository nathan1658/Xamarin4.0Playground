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
	public partial class CardKeyValue : ContentView
	{

        public static readonly BindableProperty HeaderProperty = BindableProperty.Create("Header", typeof(String), typeof(CardKeyValue), "DEFAULT_HEADER");

        public String Title
        {
            get { return (String)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(string), typeof(CardKeyValue), "DEFAULT_VALUE");

        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        public CardKeyValue ()
		{
			InitializeComponent ();
		}


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if(propertyName == HeaderProperty.PropertyName)
            {
                headerLabel.Text = Title;
            }
            if(propertyName == ValueProperty.PropertyName)
            {
                valueLabel.Text = Value;
            }
        }

    }
}