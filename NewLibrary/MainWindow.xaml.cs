using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NewLibrary.View;

namespace NewLibrary;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        ContentFrame.Navigate(typeof(AllBooksPage));
    }

    private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
    {
        NavigationViewItem item = args.SelectedItem as NavigationViewItem;
        if (item != null)
        {
            switch (item.Tag.ToString())
            {
                case "AllBooks":
                    ContentFrame.Navigate(typeof(AllBooksPage));
                    NavView.Header = "All Books";
                    break;
                case "ByGenre":
                    ContentFrame.Navigate(typeof(Genre));
                    NavView.Header = "By Genre";
                    break;
                case "Favorites":
                    ContentFrame.Navigate(typeof(FavoritesPage));
                    NavView.Header = "Favorites";
                    break;
            }
        }
    }
}