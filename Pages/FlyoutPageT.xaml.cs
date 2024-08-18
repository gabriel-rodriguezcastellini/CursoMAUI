namespace CursoMAUI.Pages;

public partial class FlyoutPageT : FlyoutPage
{
    public FlyoutPageT()
    {
        InitializeComponent();
        flyoutPage.collectionView.SelectionChanged += CollectionView_SelectionChanged;
    }

    private void CollectionView_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection[0] is FlyoutPageItem item)
        {
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType)!);
            IsPresented = false;
        }
    }
}