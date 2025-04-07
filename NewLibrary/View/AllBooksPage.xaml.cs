using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace NewLibrary.View
{
    public sealed partial class AllBooksPage : Page
    {
        public ObservableCollection<Book> Books { get; set; }

        public AllBooksPage()
        {
            this.InitializeComponent();
            Books = (Application.Current as App).Books;
        }

        private void ToggleFavorite_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Book book = button.DataContext as Book;
            book.IsFavorite = !book.IsFavorite;
        }
    }
}