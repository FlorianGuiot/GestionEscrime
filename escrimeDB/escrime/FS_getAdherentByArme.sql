create procedure getAdherentByArme
@idArme integer
as
	select a.id, nom, prenom, dateNaissance, licence, a.idClub from Adherent a join participer p on p.idAdherent = a.id join competition c on c.id = p.idCompetition where idArme = @idArme group by a.id, nom, prenom, dateNaissance, licence, a.idClub order by avg(classement);
