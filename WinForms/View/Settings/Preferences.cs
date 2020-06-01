using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Utilities.Helpers;
using Utilities.POCO;
using WinForms.Resources.Views;

namespace WinForms.View.Settings
{
    public partial class Preferences : BaseForm
    {
        private StartPreferences preferences;
        public Preferences()
        {
            InitializeComponent();
            InitLabels();

            preferences = FileHelper.ReadPreferences();

            BindData();
            ShowSaveButton();

        }

        public Preferences(bool showConfirmCancelButtons) : this()
        {
            if (showConfirmCancelButtons)
            {
                ShowConfirmCancelButtons();
            }
        }

        private void InitLabels()
        {
            RbMenLeague.Text = FormResources.MenLeague;
            RbWomenLeague.Text = FormResources.WomenLeague;
            LbLanguageTitle.Text = FormResources.Language;
            GbLanguage.Text = FormResources.ChooseLanguage;
            GbLeague.Text = FormResources.ChooseLeague;
            BtnSave.Text = FormResources.Save;
            BtnCancel.Text = FormResources.Cancel;
            BtnConfirm.Text = FormResources.Confirm;
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

            if(preferences.LanguageId != 0 && (Languages)preferences.LanguageId == Languages.Croatian)
            {
                CbLanguage.SelectedIndex = 1;
            } else
            {
                CbLanguage.SelectedIndex = 0;
            }

            RbMenLeague.Tag = (int)Leagues.MenLeague;
            RbWomenLeague.Tag = (int)Leagues.WomanLeague;

            if(preferences.LeagueId != 0 && (Leagues)preferences.LeagueId == Leagues.WomanLeague)
            {
                RbWomenLeague.Checked = true;
            } else
            {
                RbMenLeague.Checked = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var selectedLeague = (int)RbContainer.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;
            var selectedLanguage = ((KeyValuePair<int, string>)CbLanguage.SelectedItem).Key;

            var prefs = FileHelper.ReadPreferences();

            prefs.LeagueId = selectedLeague;
            prefs.LanguageId = selectedLanguage;

            WritePreferencesAndClose(prefs);
        }
    }
}