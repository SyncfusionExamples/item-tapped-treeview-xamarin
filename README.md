# item-tapped-treeview-xamarin

This repository demonstrates how to handle the item tapped event in the Xamarin.Forms SfTreeView control. It provides a sample implementation that responds to user taps on tree nodes, allowing you to execute custom logic or display alerts when a node is selected.

## Sample

### XAML
```xaml
<ContentPage.BindingContext>
        <local:FileManagerViewModel x:Name="viewModel"/>
    </ContentPage.BindingContext>

    <ContentPage.Behaviors>
        <local:Behavior/>
    </ContentPage.Behaviors>

    <syncfusion:SfTreeView x:Name="treeView"
                           ChildPropertyName="SubFiles"
                           ItemTemplateContextType="Node"
                           ItemsSource="{Binding ImageNodeInfo}" >
        <syncfusion:SfTreeView.ItemTemplate>
            <DataTemplate>
                <Grid x:Name="grid" RowSpacing="0" >
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*" />
                        <RowDefinition Height="1" />
                    </Grid.RowDefinitions>
                    <Grid RowSpacing="0" Grid.Row="0">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="40" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <Grid Padding="5,5,5,5">
                            <Image Source="{Binding Content.ImageIcon}"
                                   VerticalOptions="Center"
                                   HorizontalOptions="Center"
                                   HeightRequest="35" 
                                   WidthRequest="35"/>
                        </Grid>
                        <Grid Grid.Column="1"              
                              RowSpacing="1"
                              Padding="1,0,0,0"
                              VerticalOptions="Center">
                            <Label LineBreakMode="NoWrap"
                                   Text="{Binding Content.ItemName}"
                                   VerticalTextAlignment="Center">
                            </Label>
                        </Grid>
                    </Grid>
                </Grid>
            </DataTemplate>
        </syncfusion:SfTreeView.ItemTemplate>
    </syncfusion:SfTreeView>
```

### Behavior
```csharp
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
```

## Requirements to run the demo
Visual Studio 2017 or Visual Studio for Mac.
Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
