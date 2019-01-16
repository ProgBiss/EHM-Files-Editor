using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des latéralités.
  /// </summary>
  public enum LateralityEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.RightHanded))]
    RightHanded = 0,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.LeftHanded))]
    LeftHanded = 1
  }
}
