using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace teste_app
{
    public partial class MainPage : ContentPage
    {
        private readonly ApiConnection apiConnection;

        public MainPage()
        {
            InitializeComponent();
            apiConnection = new ApiConnection();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                string swaggerjson = await apiConnection.GetSwaggerJsonAsync();
                // Faça o tratamento dos dados recebidos, por exemplo, exiba-os em uma caixa de texto
                TxtResultado.Text = swaggerjson;
            }
            catch (Exception ex)
            {
                // Tratamento de erro caso ocorra uma exceção
                TxtResultado.Text = $"Erro: {ex.Message}";
            }
        }

    }
}
