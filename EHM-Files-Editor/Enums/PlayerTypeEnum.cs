using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des types de joueurs (2e chiffre du potentiel).
  /// </summary>
  public enum PlayerTypeEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Goon))]
    Goon = 0,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SniperDefDef))]
    SniperDefDef = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.PlaymakerDefDef))]
    PlaymakerDefDef = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.AllAroundForwardDefDef))]
    AllAroundForwardDefDef = 3,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.PowerForwardDefDef))]
    PowerForwardDefDef = 4,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TwoWayForwardDefDef))]
    TwoWayForwardDefDef = 5,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.PositioningDefSmartAllAroundForward))]
    PositioningDefSmartAllAroundForward = 6,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.PhysDefAllAroundForward))]
    PhysDefAllAroundForward = 7,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.OffDefAllAroundForward))]
    OffDefAllAroundForward = 8,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.CharacterPlayer))]
    CharacterPlayer = 9,
  }
}
