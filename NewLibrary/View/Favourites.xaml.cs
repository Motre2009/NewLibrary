using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;
using System.Linq;

namespace NewLibrary.View;

public sealed partial class FavoritesPage : Page
{
    public ObservableCollection<Book> Books { get; set; }
    public ObservableCollection<Book> FavoriteBooks { get; set; }

    public FavoritesPage()
    {
        this.InitializeComponent();
        Books = (Application.Current as App).Books;
        FavoriteBooks = new ObservableCollection<Book>(Books.Where(b => b.IsFavorite));
        foreach (var book in Books)
        {
            book.PropertyChanged += Book_PropertyChanged;
        }
    }

    private void Book_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(Book.IsFavorite))
        {
            FavoriteBooks.Clear();
            foreach (var book in Books.Where(b => b.IsFavorite))
            {
                FavoriteBooks.Add(book);
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