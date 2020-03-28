using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;

namespace WinForms.View.Settings
{
    public partial class Preferences : BaseForm
    {
        public Preferences(bool showConfirmCancelButtons = false)
        {
            InitializeComponent();
            BindData();

            if (showConfirmCancelButtons)
            {
                ShowConfirmCancelButtons();
            }
            else
            {
                ShowSaveButton();
            }
        }

        private void ShowSaveButton()
        {
            BtnSave.Visible = true;

            BtnConfirm.Visible = false;
            BtnCancel.Visible = false;

            AcceptButton = BtnSave;
            CancelButton = null;
        }

        private void ShowConfirmCancelButtons()
        {
            BtnSave.Visible = false;

            BtnConfirm.Visible = true;
            BtnCancel.Visible = true;

            BtnConfirm.Click += BtnSave_Click;

            AcceptButton = BtnConfirm;
            CancelButton = BtnCancel;
        }       

        private void BindData()
        {
            var languages = new Dictionary<int, string>
            {
                {(int)Languages.English, "English"},
                {(int)Languages.Croatian, "Hrvatski"},
            };

            CbLanguage.DataSource = new BindingSource(languages, null);
            CbLanguage.DisplayMember = "Value";
            CbLanguage.ValueMember = "Key";

            CbLanguage.SelectedIndex = 0;

            RbMenLeague.Tag = (int)Leagues.MenLeague;
            RbWomenLeague.Tag = (int)Leagues.WomanLeague;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var selectedLeague = (int)RbContainer.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;
            var selectedLanguage = ((KeyValuePair<int, string>)CbLanguage.SelectedItem).Key;

            var prefs = new StartPreferences
            {
                LeagueId = selectedLeague,
                LanguageId = selectedLanguage
            };

            try
            {
                FileHelper.WritePreferences(new List<StartPreferences> { prefs });
                MessageBox.Show("Succesfully saved!", "Success");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
                MessageBox.Show(ex.Message);
            }


        }
    }
}
