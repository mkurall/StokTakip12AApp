using Newtonsoft.Json;
using StokTakip12AApp.Api;
using StokTakip12AApp.Models;

namespace StokTakip12AApp
{
    public partial class Form1 : Form
    {
        string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJrdWxsYW5pY2lpZCI6IjEiLCJrdWxsYW5pY2lhZCI6ImFkbWluIiwieWV0a2kiOiIwIiwibmJmIjoxNzA4OTMzMzk4LCJleHAiOjE3MDk1MzgxOTgsImlzcyI6Imh0dHBzOi8vc3Rva3Rha2lwLmt1cmFsbC5jb20vIiwiYXVkIjoiaHR0cHM6Ly9zdG9rdGFraXAua3VyYWxsLmNvbS8ifQ.e8NReDAU5dAzWBwiJWImd8v4rKi5nJEoreIYTlTNZYw";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync(txtAdres.Text);

            lblStatusCode.Text = resp.StatusCode.ToString();
            txtResponse.Text = await resp.Content.ReadAsStringAsync();
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            HttpResponseMessage resp = await HttpUtils.PostAsync(txtAdres.Text, txtPostParamtre.Text);

            lblStatusCode.Text = resp.StatusCode.ToString();
            txtResponse.Text = await resp.Content.ReadAsStringAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ApiCevap cevap = await ApiV1.Login("admin", "1234");

            txtResponse.Text = cevap.Data.ToString();

            HttpUtils.SetToken(cevap.Data.ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            ApiCevap cevap = await ApiV1.KategorileriGetir();

            List<Kategori> liste = JsonConvert.DeserializeObject<List<Kategori>>(cevap.Data.ToString());

            if (cevap.BasariliMi)
            {
                txtResponse.Text = cevap.Data.ToString();
            }
            else
            {
                txtResponse.Text = cevap.HataMesaji;
            }


        }

        private async void button3_Click(object sender, EventArgs e)
        {
            ApiCevap cevap = await ApiV1.UrunleriGetir();

            List<Urun> liste = JsonConvert.DeserializeObject<List<Urun>>(cevap.Data.ToString());

            if (cevap.BasariliMi)
            {
                txtResponse.Text = cevap.Data.ToString();
            }
            else
            {
                txtResponse.Text = cevap.HataMesaji;
            }

        }
    }
}