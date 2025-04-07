using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NewLibrary.View;

namespace NewLibrary;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        this.InitializeComponent();
        ContentFrame.Navigate(typeof(AllBooksPage)); // Початкова сторінка
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
                    NavView.Header = "Усі книги";
                    break;
                case "ByGenre":
                    ContentFrame.Navigate(typeof(Genre));
                    NavView.Header = "За жанрами";
                    break;
                case "Favorites":
                    ContentFrame.Navigate(typeof(FavoritesPage));
                    NavView.Header = "Вибране";
                    break;
            }
        }
    }
}