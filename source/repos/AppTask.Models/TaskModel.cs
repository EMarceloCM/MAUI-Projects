using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AppTask.Models
{
    public class TaskModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime PrevisionDate { get; set;}
        
        private bool _IsCompleted;
        public bool IsCompleted { 
            get { return _IsCompleted; } 
            set { _IsCompleted = value; OnPropertyChanged(nameof(IsCompleted)); } 
        }
        public DateTime Created { get; set;}
        public DateTime Updated { get; set;}
        public ObservableCollection<SubTaskModel> SubTasks { get; set;} = new ObservableCollection<SubTaskModel>();

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}