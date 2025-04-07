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
                new Book { Title = "Дюна", Author = "Френк Герберт", Genre = "Фантастика", CoverImage = new Uri("ms-appx:///Assets/Dune.jpg"), IsFavorite = false },
                new Book { Title = "Шерлок Холмс", Author = "Артур Конан Дойл", Genre = "Детектив", CoverImage = new Uri("ms-appx:///Assets/Sherlock.jpg"), IsFavorite = true },
                new Book { Title = "Гордість і упередження", Author = "Джейн Остін", Genre = "Роман", CoverImage = new Uri("ms-appx:///Assets/Pride.jpg"), IsFavorite = false },
                new Book { Title = "1984", Author = "Джордж Орвелл", Genre = "Фантастика", CoverImage = new Uri("ms-appx:///Assets/1984.jpg"), IsFavorite = true },
                new Book { Title = "Вбивство у Східному експресі", Author = "Агата Крісті", Genre = "Детектив", CoverImage = new Uri("ms-appx:///Assets/Murder.jpg"), IsFavorite = false },
                new Book { Title = "Джейн Ейр", Author = "Шарлотта Бронте", Genre = "Роман", CoverImage = new Uri("ms-appx:///Assets/JaneEyre.jpg"), IsFavorite = true },
                new Book { Title = "Гра престолів", Author = "Джордж Р. Р. Мартін", Genre = "Фантастика", CoverImage = new Uri("ms-appx:///Assets/GoT.jpg"), IsFavorite = false },
                new Book { Title = "Собака Баскервілів", Author = "Артур Конан Дойл", Genre = "Детектив", CoverImage = new Uri("ms-appx:///Assets/Hound.jpg"), IsFavorite = false },
                new Book { Title = "Анна Кареніна", Author = "Лев Толстой", Genre = "Роман", CoverImage = new Uri("ms-appx:///Assets/Anna.jpg"), IsFavorite = true },
                new Book { Title = "Місто кісток", Author = "Кассандра Клер", Genre = "Фантастика", CoverImage = new Uri("ms-appx:///Assets/City.jpg"), IsFavorite = false }
            };

            var mainWindow = new MainWindow();
            mainWindow.Activate();
        }
    }
}