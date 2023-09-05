using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Collection1
{	
	public partial class ItemView : ContentView
	{
		private readonly ObservableCollection<DeskItem> deskItems = new ObservableCollection<DeskItem>
		{
			new DeskItem
			{
				Name = "Yeti Mug", Description = "Ramsey Onboarding Yeti Mug", ImageSource = "https://yeti-web.imgix.net/7dfc6982d2e8cff9/W-Drinkware_Tumbler_20oz_Navy_Studio_PrimaryB.png?bg=0fff&auto=format&w=846&h=846"
			},
			new DeskItem
			{
				Name = "Chemex", Description = "Coffee brewer for the coffee club", ImageSource = "https://m.media-amazon.com/images/I/61lrld81vxL._AC_SX466_.jpg",
				ContainedItems = new ObservableCollection<DeskItem>
				{
					new DeskItem
					{ Name = "High Brow Coffee", Description = "Guatemalan coffee, with tasting notes of Orange Juice, Cardamom, Brown Sugar", ImageSource = "https://highbrow.coffee/cdn/shop/products/GuatV1.jpg?v=1678928657" }
				}
			},
			new DeskItem
			{
				Name = "Boston Baked Beans", Description = "Also called Boston Baked Bens", ImageSource = ""
			}

		};

		public ItemView ()
		{
			InitializeComponent ();
            this.ItemCollection.ItemsSource = this.deskItems;
		}

		private void ItemSelected(object sender, SelectionChangedEventArgs e)
		{
			var item = e.CurrentSelection[0] as DeskItem;
			if (item.ContainedItems.Count > 0)
			{
				this.Navigation.PushAsync(new ItemDetailPage(item.ContainedItems));
			}
		}
	}
}

