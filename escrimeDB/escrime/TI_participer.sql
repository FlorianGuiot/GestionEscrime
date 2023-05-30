--V�rifie que le participant ajouter ma�trise l'arme de la comp�tition
--V�rifie que le classement du participant n'est pas d�j� attribu�
create trigger TI_participer on participer
instead of insert, update
as
begin
	if not exists (select idAdherent from armer where idAdherent = (select idAdherent from inserted) and idArme = (select idArme from competition where id = (select idCompetition from inserted)))
	begin
		RAISERROR ('Le participant ne ma�trise pas l arme de la comp�tition.', 16, 1)
�������	ROLLBACK TRANSACTION
	end

	if exists (select classement from Participer where idCompetition = (select idCompetition from inserted) and classement = (select classement from inserted))
	begin
		RAISERROR ('Cette place du classment est d�j� attribu�.', 16, 1)
�������	ROLLBACK TRANSACTION
	end
end;