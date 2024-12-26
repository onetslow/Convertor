namespace CERCER;

public partial class Hello : ContentPage
{
    public Hello()
    {
        InitializeComponent();
        StartLoading();
    }

    private async void StartLoading()
    {
         await Task.Delay(5000); // Имитация загрузки на 3 секунды
         Application.Current.MainPage = new MainPage(); // Переход на страницу 
       
    }

}