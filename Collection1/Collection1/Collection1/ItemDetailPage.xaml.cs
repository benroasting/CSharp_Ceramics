using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Collection1
{	
	public partial class ItemDetailPage : ContentPage
	{	
		public ItemDetailPage (ObservableCollection<DeskItem> containedItems)
		{
			InitializeComponent ();
            this.ItemDetailCollection.ItemCollection.ItemsSource = containedItems;
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

