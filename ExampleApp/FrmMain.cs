using System;
using System.IO;
using System.Windows.Forms;

namespace ExampleApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Laim.Lang.LanguagePicker.Language = "en_gb";
            Laim.Lang.LanguagePicker.LanguageFileFormat = ".lang";
            Laim.Lang.LanguagePicker.LanguageFileName = "Language-";
            Laim.Lang.LanguagePicker.LanguageLocation = Application.StartupPath + "\\Languages\\";

            GetLangFiles();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/laim/laim.lang");
        }

        void GetLangFiles()
        {
            cbLanguage.Items.Clear();
            foreach(string i in Directory.GetFiles(Laim.Lang.LanguagePicker.LanguageLocation))
            {
                FileInfo fileInfo = new FileInfo(i);
                cbLanguage.Items.Add(fileInfo.Name);
            }
        }

        void TranslateControls()
        { 
            // control names
            lblApplicationName.Text = Laim.Lang.Translator.Translate("ApplicationName");
            lblExampleNotice.Text = Laim.Lang.Translator.Translate("ExampleNotice");
            lblLanguage.Text = Laim.Lang.Translator.Translate("LanguageLabel");
            btnRefresh.Text = Laim.Lang.Translator.Translate("RefreshButton");
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedLang = this.cbLanguage.GetItemText(this.cbLanguage.SelectedItem).Split('-', '.')[1];
                Laim.Lang.LanguagePicker.Language = selectedLang;
                TranslateControls();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetLangFiles();
        }
    }
}
