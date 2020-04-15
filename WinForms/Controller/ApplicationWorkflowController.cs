using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Properties;
using WinForms.View;

namespace WinForms.Controller
{
    class ApplicationWorkflowController
    {
        public Settings ApplicationSettings { get; }
        public Action OnApplicationExit { get; }

        public List<BaseForm> Forms { get; set; }

        public ApplicationWorkflowController()
        {
            ApplicationSettings = Settings.Default;
            Forms = new List<BaseForm>();
            OnApplicationExit = () => { };
        }

        public ApplicationWorkflowController(Action onApplicationExit) : this()
        {
            OnApplicationExit = onApplicationExit;
        }

        public void ChainForms(params BaseForm[] forms)
        {
            for (int i = 0; i < forms.Length - 1; i++)
            {
                forms[i].NextForm = forms[i + 1];
                forms[i].UserClosesApplication += OnApplicationExit;
                Forms.Add(forms[i]);
            }
            Forms.Add(forms.Last());
        }

        public void Start()
        {
            Forms.First().Show();
            Application.Run();
        }


    }
}
