using CoffeeApp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CoffeeApp
{
    public partial class MainPage : ContentPage
    {

        public List<Building> Buildings { get; set; }

        public MainPage()
        {
            Buildings = new List<Building>() { new Building("Moscow", "09.00-19.00", new List<Product> { new Product("Латте", 10) }) };
            InitializeComponent();
            this.BindingContext = this;
        }

        private void OrderButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderPage());
        }
    }
}
