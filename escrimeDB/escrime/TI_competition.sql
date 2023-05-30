--V�rifie que le g�rant d'une comp�tition est bien arbitre dans celle-ci
create TRIGGER TI_gerer on Competition
instead of INSERT, UPDATE
AS
BEGIN
	if((select idGerant from inserted) is not null)
	begin
���		IF not EXISTS (
�������		SELECT 1
�������		FROM inserted i
�������		LEFT JOIN Arbitrer a ON i.id = a.idCompetition
�������		WHERE a.idMaitreArme = i.idGerant
���		)
���		BEGIN
�������		RAISERROR ('Le g�rant n est pas arbitre dans cette comp�tition.', 16, 1)
�������		ROLLBACK TRANSACTION
���		END
	end
END