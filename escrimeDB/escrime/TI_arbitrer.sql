--V�rifie qu'il n'y est pas plus de 6 arbitre par comp�tition
create TRIGGER TI_arbitrer
ON arbitrer
after INSERT
AS
BEGIN
	if exists (select id from competition c join arbitrer a on a.idCompetition = c.id group by id having count(idMaitreArme) > 6)
���	BEGIN
�������	RAISERROR ('Il ne peut pas y avoir plus de 6 arbitre par comp�tition.', 16, 1);
�������	ROLLBACK TRANSACTION;
���	END
END
