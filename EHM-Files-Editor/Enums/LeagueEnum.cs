using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des ligues (pour savoir l'identifiant d'équipe).
  /// </summary>
  public enum LeagueEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.NHL))]
    NHL = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.AHL))]
    AHL = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.JNR))]
    JNR = 3
  }
}
