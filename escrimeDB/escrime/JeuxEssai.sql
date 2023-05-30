INSERT INTO club (nom, ville, cotisation) VALUES
    ('Escrime Club Paris', 'Paris', 200),
    ('Lyon Escrime Club', 'Lyon', 150),
    ('Club d''Escrime de Marseille', 'Marseille', 180),
    ('Bordeaux Escrime', 'Bordeaux', 175),
    ('Escrime Club de Toulouse', 'Toulouse', 190);

INSERT INTO Arme (libelle) VALUES
    ('Fleuret'),
    ('Epée'),
    ('Sabre');

INSERT INTO Adherent (nom, prenom, dateNaissance, licence, idClub) VALUES
    ('Dupont', 'Paul', '13-01-1990', 'L1234', (select id from club where nom = 'Escrime Club Paris')),
    ('Durand', 'Sophie', '21-11-1992', 'L5678', (select id from club where nom = 'Escrime Club Paris')),
    ('Martin', 'Jean', '08-08-1988', 'L9123', (select id from club where nom = 'Lyon Escrime Club')),
    ('Rousseau', 'Camille', '03-02-1995', 'L4567', (select id from club where nom = 'Lyon Escrime Club')),
    ('Leblanc', 'Pierre', '25-12-1998', 'L8901', (select id from club where nom = 'Club d''Escrime de Marseille')),
    ('Chevalier', 'Marie', '30-06-1991', 'L2345', (select id from club where nom = 'Club d''Escrime de Marseille')),
	('Martin', 'Edouard', '01-01-2000', 'L3000', (select id from club where nom = 'Bordeaux Escrime')),
	('LaPierre', 'Thierry', '02-02-1999', 'L3001', (select id from club where nom = 'Bordeaux Escrime')),
	('LaMeute', 'Henry', '03-03-2001', 'L3002', (select id from club where nom = 'Escrime Club de Toulouse')),
	('LaPierre', 'Thomas', '04-04-2001', 'L3003', (select id from club where nom = 'Escrime Club de Toulouse'));

INSERT INTO	Armer (idAdherent, idArme) VALUES
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from arme where libelle = 'Fleuret')),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from arme where libelle = 'Fleuret')),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from arme where libelle = 'Fleuret')),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from arme where libelle = 'Fleuret')),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from arme where libelle = 'Fleuret')),
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from arme where libelle = 'Epée')),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from arme where libelle = 'Epée')),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from arme where libelle = 'Epée')),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from arme where libelle = 'Epée')),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from arme where libelle = 'Epée')),
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from arme where libelle = 'Sabre')),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from arme where libelle = 'Sabre')),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from arme where libelle = 'Sabre')),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from arme where libelle = 'Sabre')),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from arme where libelle = 'Sabre'));

INSERT INTO MaitreArme (brevet, id) VALUES
    ('Brevet FFE 1', (select id from adherent where nom = 'Dupont' and prenom = 'Paul')),
    ('Brevet FFE 2', (select id from adherent where nom = 'Martin' and prenom = 'Jean')),
    ('Brevet FFE 3', (select id from adherent where nom = 'LeBlanc' and prenom = 'Pierre')),
	('Brevet FFE 2', (select id from adherent where nom = 'Martin' and prenom = 'Edouard')),
	('Brevet FFE 3', (select id from adherent where nom = 'LaMeute' and prenom = 'Henry'));

INSERT INTO Competition (date, idClub, idArme, idGerant) VALUES
    ('15-03-2023', (select id from club where nom = 'Escrime Club Paris'), (select id from arme where libelle = 'Fleuret'), (select id from adherent where nom = 'Dupont' and prenom = 'Paul')),
    ('05-04-2023', (select id from club where nom = 'Lyon Escrime Club'), (select id from arme where libelle = 'Epée'), (select id from adherent where nom = 'Martin' and prenom = 'Jean')),
    ('20-05-2023', (select id from club where nom = 'Club d''Escrime de Marseille'), (select id from arme where libelle = 'Sabre'), (select id from adherent where nom = 'LeBlanc' and prenom = 'Pierre')),
    ('10-06-2023', (select id from club where nom = 'Bordeaux Escrime'), (select id from arme where libelle = 'Fleuret'), (select id from adherent where nom = 'Martin' and prenom = 'Edouard')),
    ('02-07-2023', (select id from club where nom = 'Escrime Club de Toulouse'), (select id from arme where libelle = 'Epée'), (select id from adherent where nom = 'LaMeute' and prenom = 'Henry'));

INSERT INTO Participer (idAdherent, idCompetition, classement) VALUES
    ((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club Paris')), 1),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club Paris')), 2),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club Paris')), 3),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club Paris')), 4),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club Paris')), 5),
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from competition where idClub = (select id from club where nom = 'Lyon Escrime Club')), 1),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from competition where idClub = (select id from club where nom = 'Lyon Escrime Club')), 2),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from competition where idClub = (select id from club where nom = 'Lyon Escrime Club')), 3),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from competition where idClub = (select id from club where nom = 'Lyon Escrime Club')), 4),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from competition where idClub = (select id from club where nom = 'Lyon Escrime Club')), 5),
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from competition where idClub = (select id from club where nom = 'Club d''Escrime de Marseille')), 1),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from competition where idClub = (select id from club where nom = 'Club d''Escrime de Marseille')), 2),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from competition where idClub = (select id from club where nom = 'Club d''Escrime de Marseille')), 3),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from competition where idClub = (select id from club where nom = 'Club d''Escrime de Marseille')), 4),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from competition where idClub = (select id from club where nom = 'Club d''Escrime de Marseille')), 5),
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from competition where idClub = (select id from club where nom = 'Bordeaux Escrime')), 1),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from competition where idClub = (select id from club where nom = 'Bordeaux Escrime')), 2),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from competition where idClub = (select id from club where nom = 'Bordeaux Escrime')), 3),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from competition where idClub = (select id from club where nom = 'Bordeaux Escrime')), 4),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from competition where idClub = (select id from club where nom = 'Bordeaux Escrime')), 5),
	((select id from adherent where nom = 'Durand' and prenom = 'Sophie'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club de Toulouse')), 1),
	((select id from adherent where nom = 'Rousseau' and prenom = 'Camille'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club de Toulouse')), 2),
	((select id from adherent where nom = 'Chevalier' and prenom = 'Marie'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club de Toulouse')), 3),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thierry'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club de Toulouse')), 4),
	((select id from adherent where nom = 'LaPierre' and prenom = 'Thomas'), (select id from competition where idClub = (select id from club where nom = 'Escrime Club de Toulouse')), 5);
	

INSERT INTO Arbitrer (idCompetition, idMaitreArme) VALUES
    ((select id from competition where idClub = (select id from club where nom = 'Escrime Club Paris')), (select id from adherent where nom = 'Dupont' and prenom = 'Paul')),
    ((select id from competition where idClub = (select id from club where nom = 'Lyon Escrime Club')), (select id from adherent where nom = 'Martin' and prenom = 'Jean')),
    ((select id from competition where idClub = (select id from club where nom = 'Club d''Escrime de Marseille')), (select id from adherent where nom = 'LeBlanc' and prenom = 'Pierre')),
    ((select id from competition where idClub = (select id from club where nom = 'Bordeaux Escrime')), (select id from adherent where nom = 'Martin' and prenom = 'Edouard')),
    ((select id from competition where idClub = (select id from club where nom = 'Escrime Club de Toulouse')), (select id from adherent where nom = 'LaMeute' and prenom = 'Henry'));