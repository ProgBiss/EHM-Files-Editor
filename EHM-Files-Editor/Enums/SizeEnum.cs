using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des tailles.
  /// </summary>
  public enum SizeEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootFive))]
    FiveFootFive = 0,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootSix))]
    FiveFootSix = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootSeven))]
    FiveFootSeven = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootEight))]
    FiveFootEight = 3,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootNine))]
    FiveFootNine = 4,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootTen))]
    FiveFootTen = 5,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FiveFootEleven))]
    FiveFootEleven = 6,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFoot))]
    SixFoot = 7,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootOne))]
    SixFootOne = 8,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootTwo))]
    SixFootTwo = 9,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootThree))]
    SixFootThree = 10,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootFour))]
    SixFootFour = 11,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootFive))]
    SixFootFive = 12,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootSix))]
    SixFootSix = 13,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootSeven))]
    SixFootSeven = 14,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootEight))]
    SixFootEight = 15,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootNine))]
    SixFootNine = 16,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SixFootTen))]
    SixFootTen = 17,
  }
}
