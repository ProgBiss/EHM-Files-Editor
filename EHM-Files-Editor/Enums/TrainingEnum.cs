using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des entrainements.
  /// </summary>
  public enum TrainingEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Offense))]
    Offense = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Defense))]
    Defense = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Physical))]
    Physical = 3,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goalie))]
    Goalie = 4,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Rest))]
    Rest = 5,
  }
}
