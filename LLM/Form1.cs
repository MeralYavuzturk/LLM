using Mscc.GenerativeAI;
using Mscc.GenerativeAI.Types;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LLM
{
    public partial class Form1 : Form
    {
        private GoogleAI _googleAI;
        private GenerativeModel _model;
        private ChatSession _chatSession;

        public Form1()
        {
            InitializeComponent();
            InitializeGemini();
            SetupUI();
        }

        private void InitializeGemini()
        {
            // API Anahtarýný buraya girin
            // API Anahtarýný sistemden güvenli bir þekilde çeker
            string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY");

            if (string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("Hata: API anahtarý bulunamadý! Lütfen ortam deðiþkenlerini kontrol edin.");
                return;
            }

            _googleAI = new GoogleAI(apiKey);
            _model = _googleAI.GenerativeModel("gemini-2.5-flash");

            // Sohbet oturumunu baþlat (Geçmiþi tutmasý için)
            _chatSession = _model.StartChat();
        }

        private void SetupUI()
        {
            this.Text = "Gemini AI Chatbot";
            this.AcceptButton = btnSend; // Enter tuþuna basýnca gönderir
            rtbChat.ReadOnly = true;
            txtInput.Focus();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userMsg = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(userMsg)) return;

            // 1. Kullanýcý mesajýný ekrana yaz
            AppendMessage("Siz: ", userMsg, Color.Blue);
            txtInput.Clear();
            btnSend.Enabled = false;

            try
            {
                // 2. Gemini'ye mesajý gönder
                var response = await _chatSession.SendMessage(userMsg);

                // 3. Botun cevabýný ekrana yaz
                AppendMessage("Gemini: ", response.Text, Color.DarkGreen);
            }
            catch (Exception ex)
            {
                AppendMessage("Sistem: ", "Hata oluþtu: " + ex.Message, Color.Red);
            }
            finally
            {
                btnSend.Enabled = true;
                txtInput.Focus();
            }
        }

        private void AppendMessage(string sender, string message, Color color)
        {
            rtbChat.SelectionStart = rtbChat.TextLength;
            rtbChat.SelectionLength = 0;

            rtbChat.SelectionColor = color;
            rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Bold);
            rtbChat.AppendText(sender);

            rtbChat.SelectionColor = Color.Black;
            rtbChat.SelectionFont = new Font(rtbChat.Font, FontStyle.Regular);
            rtbChat.AppendText(message + Environment.NewLine + Environment.NewLine);

            // Otomatik aþaðý kaydýr
            rtbChat.ScrollToCaret();
        }
    }
}