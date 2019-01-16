using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des pays.
  /// </summary>
  public enum CountryEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Canada))]
    Canada = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.USA))]
    USA = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Russia))]
    Russia = 3,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Czech))]
    Czech = 4,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Sweden))]
    Sweden = 5,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Finland))]
    Finland = 6,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Belarus))]
    Belarus = 7,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Slovakia))]
    Slovakia = 8,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Norway))]
    Norway = 9,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Germany))]
    Germany = 10,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Others))]
    Others = 11,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Italia))]
    Italia = 12,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Austria))]
    Austria = 13,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Latvia))]
    Latvia = 14,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Ukraine))]
    Ukraine = 15,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Slovenia))]
    Slovenia = 16,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Switzerland))]
    Switzerland = 17,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Polonia))]
    Polonia = 18,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.France))]
    France = 19,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.Japan))]
    Japan = 20,
  }
}
