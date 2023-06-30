using AppTask.Models;
using Task.Libraries.Fix;
using Task.Repositories;

namespace Task.Views;

public partial class AddEditTaskPage : ContentPage
{
    private ITaskModelRepository _repository;
    private TaskModel _task;
	public AddEditTaskPage()
	{
		InitializeComponent();
        _repository = new TaskModelRepository();
        //cria task nova
        _task = new TaskModel();

        //vincula layout a tarefa
        BindableLayout.SetItemsSource(BindableLayout_Steps, _task.SubTasks);
	}
    public AddEditTaskPage(TaskModel task)
    {
        InitializeComponent();
        _repository = new TaskModelRepository();
        _task = task;
        FillFields();

        //vincula layout a tarefa
        BindableLayout.SetItemsSource(BindableLayout_Steps, _task.SubTasks);
    }

    private void FillFields()
    {
        Entry_TaskName.Text = _task.Name;
        Editor_TaskDescription.Text = _task.Description;
        DatePicker_TaskDate.Date = _task.PrevisionDate;
    }

    private async void AddStep(object sender, EventArgs e)
    {
        var stepName = await DisplayPromptAsync("Etapa(subtarefa)", "Digite o nome da etapa(subtarefa):", "Adicionar", "Cancelar");
        if (!string.IsNullOrWhiteSpace(stepName))
        {
            _task.SubTasks.Add(new SubTaskModel { Name = stepName, IsCompleted = false });
        }
        KeyboardFix.HideKeyBoard();
    }

    private void CloseModal(object sender, EventArgs e)
    {
        KeyboardFix.HideKeyBoard();
        Navigation.PopModalAsync();
    }

    private void SaveData(object sender, EventArgs e)
    {
        KeyboardFix.HideKeyBoard();
        //obter os dados
        GetDataFromForm();
        //validar os dados
        bool valid = ValidateData();
        //salvar os dados
        if (valid) 
        {
            SaveInDatabase();
            //fechar a tela
            Navigation.PopModalAsync();
            //solicitar att da listagem da tela anterior
            UpdateMainPageList();
        }
    }

    private void UpdateMainPageList()
    {
        var navPage = App.Current.MainPage as NavigationPage;
        var startPage = navPage.CurrentPage as StartPage;
        startPage.LoadData();
    }

    private void SaveInDatabase()
    {
        //Caso seja nova task, ainda nao possui ID
        if (_task.Id == 0)
            _repository.Add(_task);
        else
            _repository.Update(_task);
    }

    private bool ValidateData()
    {
        lblTaskName_Required.IsVisible = false;
        lblTaskDescription_Required.IsVisible = false;

        bool validResult = true;
        if (string.IsNullOrWhiteSpace(_task.Name))
        {
            lblTaskName_Required.IsVisible = true;
            validResult = false;
        }
        if (string.IsNullOrWhiteSpace(_task.Description))
        {
            lblTaskDescription_Required.IsVisible = true;
            validResult = false;
        }

        return validResult;
    }

    private void GetDataFromForm()
    {
        _task.Name = Entry_TaskName.Text;
        _task.Description = Editor_TaskDescription.Text;
        _task.PrevisionDate = DatePicker_TaskDate.Date;
        _task.PrevisionDate = _task.PrevisionDate.AddHours(23);
        _task.PrevisionDate = _task.PrevisionDate.AddMinutes(59);
        _task.PrevisionDate = _task.PrevisionDate.AddSeconds(59);
        _task.Created = DateTime.Now;
        _task.IsCompleted = false;
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);

        DatePicker_TaskDate.WidthRequest = width - 30;
    }

    private void OnTapToDelete(object sender, TappedEventArgs e)
    {
        KeyboardFix.HideKeyBoard();
        _task.SubTasks.Remove((SubTaskModel)e.Parameter);
    }
}