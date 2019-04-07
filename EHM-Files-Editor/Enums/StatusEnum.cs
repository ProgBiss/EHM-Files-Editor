using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des statut de joueurs.
  /// </summary>
  public enum StatusEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FranchisePlayer))]
    FranchisePlayer = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.CorePlayer))]
    CorePlayer = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.RegularPlayer))]
    RegularPlayer = 3,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.MinorLeaguer))]
    MinorLeaguer = 4,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.BluechipProspect))]
    BluechipProspect = 5,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FutureRegular))]
    FutureRegular = 6,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.LongShot))]
    LongShot = 7,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TradeBait))]
    TradeBait = 8,
  }
}
