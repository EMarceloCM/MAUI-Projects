using AppTask.Models;
using Task.Repositories;
using Task.Libraries.Fix;

namespace Task.Views;

public partial class StartPage : ContentPage
{
    private ITaskModelRepository _repository;
    private IList<TaskModel> _tasks;
    public StartPage()
    {
        InitializeComponent();

        //Fazer utilizando D.I.
        _repository = new TaskModelRepository();
        LoadData();
    }

    public void LoadData()
    {
        _tasks = _repository.GetAll();
        CollectionViewTasks.ItemsSource = _tasks;
        lblEmptyText.IsVisible = _tasks.Count <= 0;
    }

    private void OnButtonClickedToAdd(object sender, EventArgs e)
    {
        KeyboardFix.HideKeyBoard();
        Navigation.PushModalAsync(new AddEditTaskPage());
    }

    private void OnFocusEntrySearch(object sender, TappedEventArgs e)
    {
        Entry_Search.Focus();
    }

    private async void OnClickedImageToDelete(object sender, TappedEventArgs e)
    {
        KeyboardFix.HideKeyBoard();
        var task = (TaskModel)e.Parameter;
        var confirm = await DisplayAlert("Confime a exclusão!", $"Tem certeza que deseja excluir a tarefa: \"{task.Name}\"?", "Sim", "Não");

        if (confirm)
        {
            _repository.Delete(task);
            LoadData();
        }
    }

    private void OnCheckboxClickedToComplete(object sender, TappedEventArgs e)
    {
        //Apareceu um problema onde o checkbox nao alterava seu estado após ser clicado, apesar de que no inicio estava funcionando, por isto a linha 54 existe
        ((CheckBox)sender).IsChecked = !((CheckBox)sender).IsChecked;
        var task = (TaskModel)e.Parameter;
        task.IsCompleted = ((CheckBox)sender).IsChecked;
        
        _repository.Update(task);
    }

    private void OnTapToEdit(object sender, TappedEventArgs e)
    {
        KeyboardFix.HideKeyBoard();
        var task = (TaskModel)e.Parameter;
        Navigation.PushModalAsync(new AddEditTaskPage(_repository.GetById(task.Id)));
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        string word = e.NewTextValue;
        CollectionViewTasks.ItemsSource = _tasks.Where(a => a.Name.ToLower().Contains(word.ToLower()));
    }

}