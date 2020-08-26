using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class Behavior : Behavior<ContentPage>
    {
        SfTreeView treeView;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            treeView = bindable.FindByName<SfTreeView>("treeView");
            treeView.ItemTapped += TreeView_Itemapped;
        }

        private void TreeView_Itemapped(object sender, Syncfusion.XForms.TreeView.ItemTappedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Item Tapped", "TreeView item tapped", "Close");
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            treeView.ItemTapped -= TreeView_Itemapped;
        }
    }
}
