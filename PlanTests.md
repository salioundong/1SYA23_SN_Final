# Classes
## Language
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| T_Class_Language_InitValid | Unitaire | Initialisation de la classe ne peut pas donner un objet null |
| T_Class_Language_InitEmptyRace | Unitaire | Initialisation avec tableau de race vide, doit passer |
| T_Class_Language_InitEmptyValues | Unitaire | Initialisation avec toutes les valeurs vides, doit passer |
| T_Class_Language_GetName_Valid | Unitaire | Getters - fonctionnement normal |
| T_Class_Language_GetName_EmptyName | Unitaire | Getters - vide doit fonctionner |
| T_Class_Language_GetDefaultRaces_Valid | Unitaire | Getters - fonctionnement normal |
| T_Class_Language_GetDefaultRaces_Empty | Unitaire | Getters - vide doit fonctionner |
| T_Class_Language_GetWriting_Valid | Unitaire | Getters - fonctionnement normal |
| T_Class_Language_GetWriting_Empty | Unitaire | Getters - vide doit fonctionner |

## Race
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| T_Class_RaceInit_Loaded | Unitaire | Initialisation - pas d'erreur |
| T_Class_RaceInit_EmptyInit | Unitaire | Initialisation - valeurs vides - pas d'erreur |
| T_ClassRace_GetName_EmptyName | Unitaire | Getters - vide doit fonctionner |
| T_ClassRace_GetName_NameOutput | Unitaire | Getters - fonctionnement normal |

## RaceSpecs
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| T_Class_RaceSpecs_Init | Unitaire | Initialisation - pas d'erreur |

## Skill
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| T_Class_SkillInit_Loaded | Unitaire | Initialisation - pas d'erreur |
| T_Class_SkillInit_EmptyInit | Unitaire | Initialisation - valeurs vides - pas d'erreur |
| T_ClassSkill_GetName_EmptyName | Unitaire | Getters - vide doit fonctionner |
| T_ClassSkill_GetName_NameOutput | Unitaire | Getters - fonctionnement normal |


## SkillBonus
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| T_Class_SkillBonusInit_Loaded | Unitaire | Initialisation - pas d'erreur |
| T_Class_SkillBonusInit_EmptyInit | Unitaire | Initialisation - valeurs vides - pas d'erreur |
| T_Class_SkillBonusInit_bonus0 | Unitaire | Getters - valeur de 0 doit afficher normalement |
| T_Class_SkillBonusInit_bonusNeg | Unitaire | Getters - valeur négative doit afficher normalement |
| T_ClassSkillBonus_GetName_EmptyName | Unitaire | Getters - vide doit fonctionner |
| T_ClassSkillBonus_GetName_NameOutput | Unitaire | Getters - fonctionnement normal |
| T_ClassSkillBonus_GetBonus_Output | Unitaire | Getters - fonctionnement normal |

## Vision
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| T_Class_VisionInit_Loaded | Unitaire | Initialisation - pas d'erreur |
| T_Class_VisionInit_EmptyInit | Unitaire | Initialisation - valeurs vides - pas d'erreur |
| T_ClassVision_GetName_EmptyName | Unitaire | Getters - vide doit fonctionner |
| T_ClassVision_GetName_NameOutput | Unitaire | Getters - fonctionnement normal |

# Factory
## GFactory
| Test | Niveau | Description |
| ---- | ------ | ----------- |
| InitializeLanguages_NotEmpty | Fonctionnels | Initialisation - pas d'erreur |
| InitializeSkills_NotEmpty | Fonctionnels | Initialisation - valeurs vides - pas d'erreur  |
| InitializeVisions_NotEmpty | Fonctionnels | Initialisation - valeurs vides - pas d'erreur  |
| GetLanguages_NotEmpty | Fonctionnels | Récupération des valeurs ne doit pas retourner de tableau vide |
| GetSkills_NotEmpty | Fonctionnels | Récupération des valeurs ne doit pas retourner de tableau vide |
| GetVisions_NotEmpty | Fonctionnels | Récupération des valeurs ne doit pas retourner de tableau vide |
| ExecuteCommand_OnlyCommand | Fonctionnels | Éxécution de commande sans attributs supplémentaires - fonctionnel si aucun attributs nécessaires |
| ExecuteCommand_helpExtra | Fonctionnels | Exécution commande, attributs supplémentaire non utilisé |
| ExecuteCommand_vLang | Fonctionnels | Exécution commande autre |
| ExecuteCommand_vSkills | Fonctionnels | Exécution commande autre |
| ExecuteCommand_vVision | Fonctionnels | Exécution commande autre sans attributs extra |
| RequestCommand_Empty | Fonctionnels | Réception d'un input utilisateur vide - Renvoi action vide |
| RequestCommand_helpWithExtra | Fonctionnels | Commande pour le guide extra non nécessaire, mais ignorer |
| RequestCommand_Unknown | Fonctionnels | Commande inconnu renvoie la commande inconnu sans rien faire de plus |
| RequestCommand_vLang | Fonctionnels | Commande de language - fonctionnement normal |
| RequestCommand_vSkillsNoExtra | Fonctionnels | Commande pour les skills - fonctionnement normal  |