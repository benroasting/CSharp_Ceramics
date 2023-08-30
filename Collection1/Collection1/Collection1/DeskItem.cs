using System;
using System.Collections.ObjectModel;

namespace Collection1
{
	public class DeskItem
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public string ImageSource { get; set; }

		public ObservableCollection<DeskItem> ContainedItems { get; set; } = new ObservableCollection<DeskItem>();
    }
}

