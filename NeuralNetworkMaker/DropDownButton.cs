using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NeuralNetworkMaker
{
   public partial class DropDownButton : UserControl
   {
      public event EventHandler<ItemClickEventArgs> ItemClick;

      public DropDownButton()
      {
         InitializeComponent();
      }

      [Browsable(true)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
      public override string Text
      {
         get => btnDropDown.Text;
         set
         {
            btnDropDown.Text = base.Text = value;
         }
      }

      public void AddItem(string key, string text)
      {
         contextMenuStrip.Items.Add(new ToolStripMenuItem() { Name = key, Text = text });
      }

      public void RemoveItem(string key)
      {
         contextMenuStrip.Items.RemoveByKey(key);
      }

      private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
      {
         ItemClick?.Invoke(this, new ItemClickEventArgs(e.ClickedItem.Name));
      }

      private void btnDropDown_Click(object sender, EventArgs e)
      {
         contextMenuStrip.Show(btnDropDown, new Point(0, btnDropDown.Height));
      }
   }
}
