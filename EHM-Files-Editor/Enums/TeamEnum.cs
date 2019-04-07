using EHM_Files_Editor.Resources;
using System.ComponentModel.DataAnnotations;

namespace EHM_Files_Editor.Enums
{
  /// <summary>
  /// Représente l'énumération des équipes.
  /// </summary>
  public enum TeamEnum
  {
    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.AnaheimDucks))]
    AnaheimDucks = 1,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ArizonaCoyotes))]
    ArizonaCoyotes = 2,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.BostonBruins))]
    BostonBruins = 3,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.BuffaloSabres))]
    BuffaloSabres = 4,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.CalgaryFlames))]
    CalgaryFlames = 5,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.CarolinaHurricanes))]
    CarolinaHurricanes = 6,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ChicagoBlackHawks))]
    ChicagoBlackHawks = 7,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ColoradoAvalanche))]
    ColoradoAvalanche = 8,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ColumbusBlueJackets))]
    ColumbusBlueJackets = 9,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.DallasStars))]
    DallasStars = 10,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.DetroitRedWings))]
    DetroitRedWings = 11,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.EdmontonOilers))]
    EdmontonOilers = 12,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.FloridaPanthers))]
    FloridaPanthers = 13,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.LosAngelesKings))]
    LosAngelesKings = 14,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.MinnesotaWild))]
    MinnesotaWild = 15,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.MontrealCanadiens))]
    MontrealCanadiens = 16,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.NashvillePredators))]
    NashvillePredators = 17,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.NewJerseyDevils))]
    NewJerseyDevils = 18,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.NewYorkIslanders))]
    NewYorkIslanders = 19,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.NewYorkRangers))]
    NewYorkRangers = 20,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.OttawaSenators))]
    OttawaSenators = 21,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.PhiladelphiaFlyers))]
    PhiladelphiaFlyers = 22,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.PittsburghPenguins))]
    PittsburghPenguins = 23,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SanJoseSharks))]
    SanJoseSharks = 24,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.StLouisBlues))]
    StLouisBlues = 25,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TampaBayLightning))]
    TampaBayLightning = 26,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TorontoMapleLeafs))]
    TorontoMapleLeafs = 27,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.VancouverCanucks))]
    VancouverCanucks = 28,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.WashingtonCapitals))]
    WashingtonCapitals = 29,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.WinnipegJets))]
    WinnipegJets = 30,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SanDiegoGulls))]
    SanDiegoGulls = 31,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TucsonRoadrunners))]
    TucsonRoadrunners = 32,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ProvidenceBruins))]
    ProvidenceBruins = 33,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.RochesterAmericans))]
    RochesterAmericans = 34,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.StocktonHeat))]
    StocktonHeat = 35,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.CharlotteCheckers))]
    CharlotteCheckers = 36,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.RockfordIcehogs))]
    RockfordIcehogs = 37,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SanAntonioRampage))]
    SanAntonioRampage = 38,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ClevelandMonsters))]
    ClevelandMonsters = 39,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TexasStars))]
    TexasStars = 40,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.GrandRapidGriffins))]
    GrandRapidGriffins = 41,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.BakersfieldCondors))]
    BakersfieldCondors = 42,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SpringfieldThunderbirds))]
    SpringfieldThunderbirds = 43,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.OntarioReign))]
    OntarioReign = 44,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.IowaWild))]
    IowaWild = 45,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.StJohnsIcecaps))]
    StJohnsIcecaps = 46,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.MilwaukeeAdmirals))]
    MilwaukeeAdmirals = 47,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.AlbanyDevils))]
    AlbanyDevils = 48,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.BridgeportSoundtigers))]
    BridgeportSoundtigers = 49,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.HartfordWolfpacks))]
    HartfordWolfpacks = 50,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.BinghamtonSenators))]
    BinghamtonSenators = 51,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.LehighValleyPhantoms))]
    LehighValleyPhantoms = 52,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.WilkesBarreScrantonPenguins))]
    WilkesBarreScrantonPenguins = 53,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SanJoseBarracuda))]
    SanJoseBarracuda = 54,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ChicagoWolves))]
    ChicagoWolves = 55,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.SyracuseCrunch))]
    SyracuseCrunch = 56,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.TorontoMarlies))]
    TorontoMarlies = 57,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.UticaComets))]
    UticaComets = 58,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.HersheyBears))]
    HersheyBears = 59,

    [Display(ResourceType = typeof(GlobalResx), Name = nameof(GlobalResx.ManitobaMoose))]
    ManitobaMoose = 60,
  }
}
