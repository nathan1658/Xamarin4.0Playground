using System.Collections.Generic;
using VisualDemos.Models;
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
                list.Add(new Context { ChipVal = $"IT", Name = "Peter" + i });
            }
            testListView.ItemsSource = list;
            
        }
    }
}
