using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualDemos.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VisualDemos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextCardViewCell : ViewCell
    {
        public ContextCardViewCell()
        {
            InitializeComponent();

            chipsFlex.Children.Add(new Chips { Background = Color.Red, Text = "TEST@@" });

        }

        protected override async void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var context = this.BindingContext as Context;

            if (context != null)
            {
                System.Diagnostics.Debug.WriteLine($"{context.ChipVal}");                
                genChips();
                //this.ForceUpdateSize();
            }
        }


        void genChips()
        {
            var context = this.BindingContext as Context;
            if (context != null)
            {
                chipsFlex.Children.Clear();
                chipsFlex.Children.Add(new Chips { Text = context.ChipVal });
            }
        }
    }
}