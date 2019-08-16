using System.Collections.Generic;
using Xamarin.Forms;

namespace VisualDemos
{
    public partial class CardPage : ContentPage
    {
        public CardPage()
        {
            InitializeComponent();
            var list = new List<object>
            {
            };
            for (int i = 0; i < 50; i++)
            {
                list.Add(new object());
            }
            testListView.ItemsSource = list;
            
        }
    }
}
