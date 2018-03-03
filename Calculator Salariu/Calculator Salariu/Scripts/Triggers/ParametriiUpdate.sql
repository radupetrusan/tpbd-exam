SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Radu Petrusan
-- Create date: 03.03.2018
-- Description:	Creaza Trigger pentru a calcula sumele salariatilor cand parametrii sunt modificati
-- =============================================

IF OBJECT_ID('dbo.ParametriiUpdate', 'TR') IS NOT NULL 
DROP TRIGGER dbo.ParametriiUpdate
GO

CREATE TRIGGER dbo.ParametriiUpdate
   ON  Parametrii
   AFTER UPDATE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @SalariatId int = 0
	WHILE(1 = 1)
		BEGIN
			SELECT @SalariatId = MIN(Nr_crt)
			FROM Salariati WHERE Nr_crt > @SalariatId
			IF @SalariatId IS NULL BREAK

			EXEC dbo.CalculeazaSumeSalariu @SalariatId
END

END
GO
