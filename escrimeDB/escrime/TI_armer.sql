--Vérifie qu'on ne spécialise pas un maître d'arme dans une arme en particulier
create trigger TI_armer on armer
instead of insert, update
as
begin
	if exists (select id from MaitreArme where id = (select idAdherent from inserted))
	begin
		RAISERROR ('Un arbitre estd éjà spécialisé dans toutes les armes.', 16, 1)
       	ROLLBACK TRANSACTION
	end
end;