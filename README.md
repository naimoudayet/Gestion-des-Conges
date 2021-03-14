# Gestion des Conges

## TODO
* [ ] controle de saisie
* [ ] design

## Actors

### Admin
* [x] authentification
* [x] gestion des agents
    * [x] consulter
    * [x] ajouter
    * [x] modifier
    * [x] supprimer
* [x] gestion des conges
    * [x] consulter
    * [x] ajouter
    * [x] modifier
    * [x] supprimer
    * [x] accepter
    * [x] refuser
* [x] consulter solde

### Agent
* [x] authentification
* [x] gestion des agents
    * [x] consulter
    * [x] ajouter
    * [x] modifier
    * [x] supprimer
* [x] consulter solde

## Database
### User
* ID int
* Name varchar(120)
* Email varchar(120)
* Password varchar(120)
* Role(AGENT, ADMIN)  varchar(50)

### Conge
* ID int
* ID_User int
* Nbr_Jours int
* Date_Debut date
* Date_Fin date
* Adresse varchar(100)
* Num_Tel varchar(8)
* Date_Demande date
* Etat(En Attente, Accepter, Refuser) varchar(50)
