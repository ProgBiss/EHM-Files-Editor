using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des positions.
  /// </summary>
  public enum PositionEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goon))]
    Goalie = 1,
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goon))]
    Defenceman = 2,
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goon))]
    LeftWing = 3,
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goon))]
    Center = 4,
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goon))]
    RightWing = 5,
  }
}
