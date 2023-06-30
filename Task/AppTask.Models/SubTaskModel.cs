using System.ComponentModel;

namespace AppTask.Models
{
    public class SubTaskModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        
        private bool _IsCompleted;
        public bool IsCompleted
        {
            get { return _IsCompleted; }
            set { _IsCompleted = value; OnPropertyChanged(nameof(IsCompleted)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
