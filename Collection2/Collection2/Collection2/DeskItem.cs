using System.Collections.ObjectModel;

namespace Collection2
{
    public class DeskItem
    {
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public ObservableCollection<DeskItem> ContainedItems { get; set; } = new ObservableCollection<DeskItem>();
    }
}