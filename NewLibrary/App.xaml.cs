using System;
using System.Collections.ObjectModel;
using Microsoft.UI.Xaml;

namespace NewLibrary
{
    public partial class App : Application
    {
        public ObservableCollection<Book> Books { get; set; }

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            Books = new ObservableCollection<Book>
            {
                new Book { Title = "Dune", Author = "Frank Herbert", Genre = "Science Fiction", CoverImage = new Uri("ms-appx:///Assets/Dune.jpg"), IsFavorite = false },
                new Book { Title = "Sherlock Holmes", Author = "Arthur Conan Doyle", Genre = "Detective", CoverImage = new Uri("ms-appx:///Assets/Sherlock.jpg"), IsFavorite = true },
                new Book { Title = "Pride and Prejudice", Author = "Jane Austen", Genre = "Romance", CoverImage = new Uri("ms-appx:///Assets/Pride.jpg"), IsFavorite = false },
                new Book { Title = "1984", Author = "George Orwell", Genre = "Science Fiction", CoverImage = new Uri("ms-appx:///Assets/1984.jpg"), IsFavorite = true },
                new Book { Title = "Murder on the Orient Express", Author = "Agatha Christie", Genre = "Detective", CoverImage = new Uri("ms-appx:///Assets/Murder.jpg"), IsFavorite = false },
                new Book { Title = "Jane Eyre", Author = "Charlotte Brontë", Genre = "Romance", CoverImage = new Uri("ms-appx:///Assets/JaneEyre.jpg"), IsFavorite = true },
                new Book { Title = "Game of Thrones", Author = "George R. R. Martin", Genre = "Science Fiction", CoverImage = new Uri("ms-appx:///Assets/GoT.jpg"), IsFavorite = false },
                new Book { Title = "The Hound of the Baskervilles", Author = "Arthur Conan Doyle", Genre = "Detective", CoverImage = new Uri("ms-appx:///Assets/Hound.jpg"), IsFavorite = false },
                new Book { Title = "Anna Karenina", Author = "Leo Tolstoy", Genre = "Romance", CoverImage = new Uri("ms-appx:///Assets/Anna.jpg"), IsFavorite = true },
                new Book { Title = "City of Bones", Author = "Cassandra Clare", Genre = "Science Fiction", CoverImage = new Uri("ms-appx:///Assets/City.jpg"), IsFavorite = false }
            };

            var mainWindow = new MainWindow();
            mainWindow.Activate();
        }
    }
}