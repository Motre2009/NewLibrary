using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace NewLibrary.View;

public sealed partial class Genre : Page
{
    public ObservableCollection<Book> Books { get; set; }
    public ObservableCollection<Book> FilteredBooks { get; set; }

    public Genre()
    {
        this.InitializeComponent();
        Books = (Application.Current as App).Books;
        FilteredBooks = new ObservableCollection<Book>(Books);
    }

    private void GenreComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedGenre = GenreComboBox.SelectedItem as string;
        FilteredBooks.Clear();
        if (selectedGenre == "All Genres")
        {
            foreach (var book in Books)
            {
                FilteredBooks.Add(book);
            }
        }
        else
        {
            foreach (var book in Books.Where(b => b.Genre == selectedGenre))
            {
                FilteredBooks.Add(book);
            }
        }
    }

    private void ToggleFavorite_Click(object sender, RoutedEventArgs e)
    {
        Button button = sender as Button;
        Book book = button.DataContext as Book;
        book.IsFavorite = !book.IsFavorite;
    }
}