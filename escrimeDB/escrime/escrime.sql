create database escrime;

use escrime;

create table Club(
	id int identity,
	nom varchar(50),
	ville varchar(100),
	cotisation float,
	constraint pk_escrime primary key(id)
);

CREATE TABLE arme (
    id INT IDENTITY,
    libelle VARCHAR(25),
	constraint pk_arme primary key(id)
); 

CREATE TABLE Adherent (
    id INT IDENTITY,
    nom VARCHAR(25),
    prenom VARCHAR(25),
    dateNaissance DATETIME,
    licence VARCHAR(25),
    idClub INT,
	constraint pk_adherent primary key(id),
	constraint fk_adherent_club FOREIGN KEY (idClub) REFERENCES club(id)
);

create table armer(
	idAdherent int,
	idArme int,
	constraint pk_armer primary key(idAdherent, idArme),
	constraint fk_armer_adherant foreign key(idAdherent) references adherent(id),
	constraint fk_armer_arme foreign key(idArme) references arme(id)
);

create table MaitreArme(
	id int,
	brevet varchar(50),
	constraint pk_maitreArme primary key(id),
	constraint fk_maitreArme_adherent foreign key(id) references adherent(id)
);

create table Competition(
	id int identity,
	date date,
	idClub int,
	idArme int,
	idGerant int,
	constraint pk_competition primary key(id),
	constraint fk_competition_club foreign key(idClub) references club(id),
	constraint fk_competition_arme foreign key(idArme) references arme(id),
	constraint fk_competition_maitreArme foreign key(idGerant) references maitreArme(id)
);

CREATE TABLE Participer(
    idAdherent INT,
    idCompetition INT,
	classement int,
    constraint pk_participer primary key(idAdherent, idCompetition),
    constraint fk_participer_adherent FOREIGN KEY (idAdherent) REFERENCES Adherent(id),
    constraint fk_participer_competition foreign key(idCompetition) REFERENCES Competition(id)
);

create table Arbitrer(
	idCompetition int,
	idMaitreArme int,
	constraint pk_arbitrer primary key(idCompetition, idMaitreArme),
	constraint fk_arbitrer_competition foreign key(idCompetition) references competition(id),
	constraint fk_arbitrer_maitreArme foreign key(idMaitreArme) references maitreArme(id)
);

CREATE LOGIN GestionEscrime WITH PASSWORD = 'Penser@utiliser1mdpComplexe';
CREATE USER GestionEscrime FOR LOGIN GestionEscrime;
GRANT select on schema::dbo to GestionEscrime;
GRANT insert on schema::dbo to GestionEscrime;
GRANT update on schema::dbo to GestionEscrime;
GRANT delete on schema::dbo to GestionEscrime;