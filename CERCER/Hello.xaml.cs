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
         await Task.Delay(5000); // �������� �������� �� 3 �������
         Application.Current.MainPage = new MainPage(); // ������� �� �������� 
       
    }

}