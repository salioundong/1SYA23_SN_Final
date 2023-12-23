# DndTool - Guide
Utilitaire d'informations de base pour donjon et dragon (partiel).

## Commandes
- help : obtenir le guide des commandes du systèmes
- vLang : Obtenir la liste des langages 
- vSkills : Obtenir la liste des skills
- vVision : Obtenir la liste des visions possibles
- switch XX : Permet de changer la langue du logiciel 
    - XX -> EN = Le logiciel passe en mode anglais
    - XX -> FR = Le logiciel passe en mode français

# Nomenclatures de programmation
- Nom de classe : PascalCase
- Nom de fonction : PascalCase
- Nom de fonction de tests : Pascal_Snake_Case
- Nom d'attributs de classe : camelCase
- Nom de variables du programme : snake_case
- Nom de variables constantes : SCREAMING_SNAKE_CASE

# Lexique
- vd = Vitesse de déplacement
- vLang = view Languages
- vSkills = view Skils
- vVision = view Vision

# Autres patrons de conception

## Le Command

- **Encapsulation des Opérations :** Le modèle de Commande encapsule chaque opération spécifique sur les listes dans une classe de commande distincte. Chaque commande est responsable de sa propre logique.

- **Séparation des Responsabilités :** La séparation des responsabilités entre les commandes améliore la maintenabilité du code. Les modifications ou les ajouts de fonctionnalités se font de manière isolée.

## La Façade

- **Interface Unifiée pour le Sous-Système :** Ce modèle de conception fournit une interface unifiée à un sous-système. Ainsi, il définit une interface de plus haut niveau qui facilite l'utilisation du sous-système.

- **Produit Simplifié :** La Façade fournit un produit simplifié avec un grand sous-système de classes mesurant la solvabilité d'un demandeur.
