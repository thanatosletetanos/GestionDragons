# GestionDragons

# Projet de fin d’année : Orienté Objet

## Étape 1

**Mon thème :**  
Gestion d’un élevage de dragons

**Mon application permet de :**  
gérer un élevage de dragons ; créer des dragons, les nourrir, les faire évoluer et consulter leur état

**Pourquoi ce thème ?**  
Car j’aime les dragons et qu’en ce moment même je joue à un jeu d’élevage de dragons

---

## Étape 2

### Lister les entités
**Quels sont les acteurs et les objets de mon système ?**

### 1. Dragon
**Attributs :** nom, age, niveau, sante, faim  
**Comportements :** `Afficher()`, `Manger()`, `Evoluer()`

### 2. DragonFeu : Dragon
**Attributs :** temperatureFlamme, intensiteFeu, resistanceChaleur  
**Comportements :** `Afficher()`, `UtiliserPouvoir()`

### 3. DragonEau : Dragon
**Attributs :** niveauHydratation, vitesseNage, resistanceFroid  
**Comportements :** `Afficher()`, `UtiliserPouvoir()`

### 4. DragonPlante : Dragon
**Attributs :** energieNature, vitesseRegeneration, couleurEcailles  
**Comportements :** `Afficher()`, `UtiliserPouvoir()`

### 5. Nourriture
**Attributs :** nom, type, valeurNutritive, quantite  
**Comportements :** `Afficher()`, `DiminuerQuantite()`

### 6. Enclos
**Attributs :** nom, capaciteMax, typeHabitat, proprete  
**Comportements :** `AjouterDragon()`, `RetirerDragon()`, `Afficher()`

### 7. Inventaire
**Attributs :** capacite, nombreElements, listeNourritures, nom  
**Comportements :** `AjouterNourriture()`, `RetirerNourriture()`, `AfficherStock()`

### 8. Eleveur
**Attributs :** nom, niveauExperience, inventaire, listeEnclos  
**Comportements :** `NourrirDragon()`, `AjouterDragonEnclos()`, `AfficherElevage()`

---

## Étape 3

### Héritage

**DragonFeu hérite de Dragon**  
Justification : un dragon de feu est un type de dragon.

**DragonEau hérite de Dragon**  
Justification : un dragon d’eau est un type de dragon.

**DragonPlante hérite de Dragon**  
Justification : un dragon plante est un type de dragon.

### Associations / compositions

**Eleveur possède un Inventaire**  
Justification : l’éleveur a un inventaire pour stocker les ressources.

**Eleveur possède plusieurs Enclos**  
Justification : l’éleveur gère plusieurs enclos dans son élevage.

**Enclos possède plusieurs Dragon**  
Justification : un enclos contient les dragons.

**Inventaire possède plusieurs Nourriture**  
Justification : l’inventaire stocke différentes nourritures.
