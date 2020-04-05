using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using WinForms.Resources.Views;

namespace WinForms.ViewModels
{
    class PlayerStatsViewModel
    {
        [Display(Name = nameof(FormResources.PlayerName), ResourceType = typeof(FormResources))]
        public string FullName { get; set; }

        [Display(Name = nameof(FormResources.Image), ResourceType = typeof(FormResources))]
        public Image PlayerImage { get; set; }

        [Display(Name = nameof(FormResources.GoalsNumber), ResourceType = typeof(FormResources))]
        public int NoGoalsScored { get; set; }

        [Display(Name = nameof(FormResources.YellowCardNumber), ResourceType = typeof(FormResources))]
        public int NoYellowCards { get; set; }
    }
}
