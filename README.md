# Projet C# 
## Pour le cours de Programmation orientée objet BAC 1 
### Thème: refuge pour animaux
---

# Tableau des entitées

| Entité           | Attributs                                      | Comportements                                  |
|------------------|-----------------------------------------------|------------------------------------------------|
| Animal           | id, nom, age, sexe, dateArrivee              | AfficherInfos()                                |
| Chien            | race, taille, estDresse                      | AfficherInfos()                                |
| Chat             | couleur, estSterilise, poids                 | AfficherInfos()                                |
| Adoptant         | id, nom, prenom, telephone, email            | AfficherInfos()                                |
| Adoption         | id, dateAdoption, statutDossier, fraisAdoption | Valider(), Annuler(), AfficherResume()        |
| Employe          | id, nom, prenom, fonction, dateEmbauche      | AfficherInfos(), NourrirAnimal(), NettoyerEnclos() |
| Enclos           | id, nom, capacite, typeEnclos                | AjouterAnimal(), RetirerAnimal(), AfficherCapacite() |
| DossierMedical   | id, dateVisite, diagnostic, traitement, observations | AjouterObservation(), AfficherDossier() |

---

# Relations

## Héritage
- Chien hérite de Animal  
- Chat hérite de Animal  

## Associations
- Adoption possède un Animal  
- Adoption possède un Adoptant  
- Animal possède un Enclos  
- Animal possède un DossierMedical  

---

# Tableau des relations

| Classe A | Relation   | Classe B        | Justification                          |
|----------|-----------|-----------------|----------------------------------------|
| Chien    | hérite de | Animal          | Un chien est un animal                 |
| Chat     | hérite de | Animal          | Un chat est un animal                  |
| Adoption | possède un| Animal          | Une adoption concerne un animal        |
| Adoption | possède un| Adoptant        | Une adoption est liée à un adoptant    |
| Animal   | possède un| Enclos          | Un animal est hébergé dans un enclos   |
| Animal   | possède un| DossierMedical  | Un animal a un dossier médical         |

---

# Remarques

- La classe **Animal** déclare `AfficherInfos()`  
- **Chien** et **Chat** redéfinissent `AfficherInfos()`  

---

# UML
![UML shéma.](/img/UML.png "This is a sample image.")