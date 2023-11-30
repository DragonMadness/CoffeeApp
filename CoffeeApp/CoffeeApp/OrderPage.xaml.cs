using CoffeeApp.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderPage : ContentPage
	{
		public List<Building> Buildings { get; set; }
		public List<Product> Catalog {  get; set; }

		public OrderPage ()
		{
            Title = "Создание заказа";
            Catalog = new List<Product>() { new Product("Американо", 30), new  Product("Латте", 40) };
            Buildings = new List<Building>() { new Building("Moscow", "09.00-19.00", new List<Product> { new Product("Латте", 10) }) };
            InitializeComponent ();
			this.BindingContext = this;
		}

        private void BackButton_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}