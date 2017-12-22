using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JG_Final.Models
{
    public class BetterListModel
    {
        public string ItemToAdd { get; set; }
        public List<string> AllItems { get; set; }
        public List<string> SelectedItems { get; set; }

        public void AddItem()
        {
            if (!string.IsNullOrEmpty(ItemToAdd) && !AllItems.Contains(ItemToAdd))
                AllItems.Add(ItemToAdd);
            ItemToAdd = "";
        }

        public void RemoveSelected()
        {
            AllItems.RemoveAll(item => SelectedItems.Contains(item));
            SelectedItems.Clear();
        }

        public void SortItems()
        {
            AllItems.Sort();
        }
    }
}