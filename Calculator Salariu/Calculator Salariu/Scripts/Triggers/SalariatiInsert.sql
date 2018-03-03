SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Radu Petrusan
-- Create date: 03.03.2018
-- Description:	Creaza Trigger pentru a calcula sumele cand un salariat este adaugat
-- =============================================

IF OBJECT_ID('dbo.SalariatiInsert', 'TR') IS NOT NULL 
DROP TRIGGER dbo.SalariatiInsert
GO

CREATE TRIGGER dbo.SalariatiInsert
   ON  Salariati
   AFTER INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @SalariatId INT;

	SELECT @SalariatId = Nr_crt FROM inserted;

    -- Insert statements for trigger here
	EXEC dbo.CalculeazaSumeSalariu @SalariatId
END
GO
