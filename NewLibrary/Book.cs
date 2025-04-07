using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NewLibrary
{
    public class Book : INotifyPropertyChanged
    {
        private string _title;
        private string _author;
        private string _genre;
        private Uri _coverImage;
        private bool _isFavorite;

        public string Title
        {
            get => _title;
            set { _title = value; OnPropertyChanged(); }
        }
        public string Author
        {
            get => _author;
            set { _author = value; OnPropertyChanged(); }
        }
        public string Genre
        {
            get => _genre;
            set { _genre = value; OnPropertyChanged(); }
        }
        public Uri CoverImage
        {
            get => _coverImage;
            set { _coverImage = value; OnPropertyChanged(); }
        }
        public bool IsFavorite
        {
            get => _isFavorite;
            set { _isFavorite = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
