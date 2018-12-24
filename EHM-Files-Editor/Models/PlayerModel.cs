using EHM_Files_Editor.Enums;
using System;

namespace EHM_Files_Editor.Models
{
  /// <summary>
  /// Modèle des informations qu'on veut modifier d'un joueur dans EHM.
  /// </summary>
  public class PlayerModel
  {
    /// <summary>
    /// Obtient ou définit la cote "SH" actuelle.
    /// </summary>
    public int Shooting
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "SH" maximale.
    /// </summary>
    public int ShootingMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "PL" actuelle.
    /// </summary>
    public int Playmaking
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "PL" maximale.
    /// </summary>
    public int PlaymakingMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "ST" actuelle.
    /// </summary>
    public int StickHandling
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "ST" maximale.
    /// </summary>
    public int StickHandlingMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "CH" actuelle.
    /// </summary>
    public int Checking
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "CH" maximale.
    /// </summary>
    public int CheckingMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "PO" actuelle.
    /// </summary>
    public int Positioning
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "PO" maximale.
    /// </summary>
    public int PositioningMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "HI" actuelle.
    /// </summary>
    public int Hitting
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "HI" maximale.
    /// </summary>
    public int HittingMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "SK" actuelle.
    /// </summary>
    public int Skating
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "SK" maximale.
    /// </summary>
    public int SkatingMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "EN" actuelle.
    /// </summary>
    public int Endurance
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "EN" maximale.
    /// </summary>
    public int EnduranceMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "PE" actuelle.
    /// </summary>
    public int Penalty
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "PE" maximale.
    /// </summary>
    public int PenaltyMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "FA" actuelle.
    /// </summary>
    public int FaceOff
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "FA" maximale.
    /// </summary>
    public int FaceOffMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "LE" actuelle.
    /// </summary>
    public int Lead
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "LE" maximale.
    /// </summary>
    public int LeadMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "SR" actuelle.
    /// </summary>
    public int Strength
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "SR" maximale.
    /// </summary>
    public int StrengthMax
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le niveau de "POT" du joueur. Chiffre de 1 à 9.
    /// </summary>
    public int Potential
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le type de joueur.
    /// </summary>
    public PlayerTypeEnum PlayerType
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le niveau de "CON" du joueur.
    /// </summary>
    public int Consistency
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le "Greed" du joueur.
    /// </summary>
    public int Greed
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la cote "FI" du joueur.
    /// </summary>
    public int Fighting
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit l'équipe qui possède les droits du joueur.
    /// Modifie les valeurs "Rights" et "nhl_rights".
    /// </summary>
    public TeamEnum Rights
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la ligue du joueur.
    /// Permet de déterminer la valeur de "TeamId"
    /// </summary>
    public LeagueEnum League
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la position primaire.
    /// </summary>
    public PositionEnum MainPosition
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la position alternative.
    /// </summary>
    public PositionEnum AltPosition
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la latéralité du joueur.
    /// </summary>
    public LateralityEnum Laterality
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le pays du joueur.
    /// </summary>
    public CountryEnum Country
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la date de naissance.
    /// </summary>
    public DateTime BirthDate
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le salaire du joueur.
    /// </summary>
    public int Salary
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le nombre d'année du contrat.
    /// </summary>
    public int ContractLenght
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit l'année de repêchage.
    /// </summary>
    public int DraftYear
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la ronde de repêchage.
    /// </summary>
    public int DraftRound
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit l'équipe qui l'a repêché.
    /// </summary>
    public TeamEnum DraftTeam
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit si le joueur possède une clause de non mouvement.
    /// </summary>
    public bool NoTradeClause
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit si le joueur possède un contrat à 2 volets.
    /// </summary>
    public bool TwoWayClause
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le statut du joueur dans l'organisation.
    /// </summary>
    public StatusEnum StatusInOrganisation
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit si le joueur est une recrue.
    /// </summary>
    public bool IsRookie
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit l'entrainement du joueur.
    /// </summary>
    public TrainingEnum Training
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le poids du joueur.
    /// </summary>
    public int Weight
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit la taille du joueur.
    /// </summary>
    public SizeEnum Size
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le nom complet du joueuré
    /// </summary>
    public string Name
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le niveau de risque de blessure du joueur.
    /// </summary>
    public int InjuryProne
    {
      get; set;
    }

    /// <summary>
    /// Obtient ou définit le rang de sélection au repêchage du joueur.
    /// </summary>
    public int DraftRank
    {
      get; set;
    }
  }
}
