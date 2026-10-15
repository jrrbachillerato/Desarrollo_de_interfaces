namespace LoginAcceso_JRR
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if(entryUser.EsValido && entryContrasenia.EsValida)
            {
                await DisplayAlert("Bienvenido", $"{entryUser.Texto}", "OK");
                await DisplayAlert("Login", $"Usuario: {entryUser.Texto}\nContraseña: {entryContrasenia.Texto}", "OK");
                entryUser.Limpiar();
                entryContrasenia.Limpiar();
            }
            else
            {
                await DisplayAlert("Login", "Usuario o contraseña inválidos", "OK");
            }
        }
    }
}
