using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ToDoLIst.Core
{
    public class WorkTasksPageViewModel : BaseViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();

        public string NewWorkTaskTitle { get; set; }

        public string NewWorkTaskDescription { get; set; }

        public ICommand AddNewTaskCommand { get; set; }

        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
        }

        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
            };

            WorkTaskList.Add(newTask);

            NewWorkTaskTitle =string.Empty;
            NewWorkTaskDescription = string.Empty;

            PropertyChanged(this, new PropertyChangedEventArgs(nameof(NewWorkTaskTitle)));


        }
    }
}
