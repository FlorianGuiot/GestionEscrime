--V�rifie qu'on ne sp�cialise pas un ma�tre d'arme dans une arme en particulier
create trigger TI_armer on armer
instead of insert, update
as
begin
	if exists (select id from MaitreArme where id = (select idAdherent from inserted))
	begin
		RAISERROR ('Un arbitre estd �j� sp�cialis� dans toutes les armes.', 16, 1)
�������	ROLLBACK TRANSACTION
	end
end;