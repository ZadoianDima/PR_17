using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;


namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        private const string ApiUrl = "https://animechan.xyz/api/random";
        private readonly HttpClient _httpClient;

        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await DisplayRandomQuote();
            // Setting up a timer to trigger every minute
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // 60 seconds = 1 minute
            timer.Tick += async (s, _) => await DisplayRandomQuote();
            timer.Start();
        }

        private async Task DisplayRandomQuote()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(ApiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var quote = Newtonsoft.Json.JsonConvert.DeserializeObject<AnimeQuote>(json);
                    UpdateQuoteUI(quote);
                }
                else
                {
                    MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateQuoteUI(AnimeQuote quote)
        {
            lblAnime.Text = quote.Anime;
            lblCharacter.Text = $"Character: {quote.Character}";
            lblQuote.Text = $"\"{quote.Quote}\"";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await DisplayRandomQuote();
        }
    }

    public class AnimeQuote
    {
        public string Anime { get; set; }
        public string Character { get; set; }
        public string Quote { get; set; }
    }
}
