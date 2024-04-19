using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameHistoryProject.Extensions
{
    public class CategorizedListBox : ListBox
    {
        private List<string> categories;

        public CategorizedListBox()
        {
            categories = new List<string>();
            DrawMode = DrawMode.OwnerDrawFixed; // Enable custom drawing
        }

        public void AddCategory(string categoryName)
        {
            categories.Add(categoryName);
            ListViewGroup group = new ListViewGroup(categoryName);
            Items.Add(group); // Add empty group as header
        }

        public void AddItem(string itemText, string categoryName)
        {
            int categoryIndex = categories.IndexOf(categoryName);
            if (categoryIndex < 0)
            {
                throw new ArgumentException("Category not found");
            }

            Items.Insert(GetItemCountAfterGroup(categoryIndex), itemText);
        }

        private int GetItemCountAfterGroup(int categoryIndex)
        {
            int count = 0;
            for (int i = 0; i <= categoryIndex; i++)
            {
                count += Items[i] is ListViewGroup ? 1 : 0; // Count groups
                count += Items[i] is string ? 1 : 0; // Count items
            }
            return count;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e); // Call base for default drawing

            if (e.Index < 0 || e.State != DrawItemState.Selected)
            {
                return;
            }

            if (e.Index < Items.Count && Items[e.Index] is ListViewGroup group)
            {
                // Draw category header
                e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
                e.Graphics.DrawString(group.Header, e.Font, Brushes.Black, e.Bounds.Location);
            }
            else if (e.Index < Items.Count && Items[e.Index] is string)
            {
                // Draw list item
                string text = Items[e.Index].ToString();
                e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds.Location);
            }
        }
    }

}
