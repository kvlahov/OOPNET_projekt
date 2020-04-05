using System.ComponentModel.DataAnnotations;
using WinForms.Resources.Views;

namespace WinForms.ViewModels
{
    class MatchStatsViewModel
    {
        [Display(Name = nameof(FormResources.Location), ResourceType = typeof(FormResources))]
        public string Location { get; set; }

        [Display(Name = nameof(FormResources.VisitorNumber), ResourceType = typeof(FormResources))]
        public long NumberOfVisitors { get; set; }

        [Display(Name = nameof(FormResources.HomeTeam), ResourceType = typeof(FormResources))]
        public string HomeTeam { get; set; }

        [Display(Name = nameof(FormResources.AwayTeam), ResourceType = typeof(FormResources))]
        public string AwayTeam { get; set; }

    }
}
