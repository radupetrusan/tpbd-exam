SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Radu Petrusan
-- Create date: 03.03.2018
-- Description:	Procedura stocata folosita pentru calculul salariilor unui salariat
-- =============================================

IF OBJECT_ID('dbo.CalculeazaSumeSalariu', 'P') IS NOT NULL
DROP PROC dbo.CalculeazaSumeSalariu
GO


CREATE PROCEDURE dbo.CalculeazaSumeSalariu 
	-- Add the parameters for the stored procedure here
	@SalariatId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @Impozit FLOAT;
	DECLARE @CAS FLOAT;
	DECLARE @CASS FLOAT;

	DECLARE @SalariuBaza INT;
	DECLARE @ProcentSpor FLOAT;
	DECLARE @PremiiBrute INT;
	DECLARE @Retineri INT;

	DECLARE @TotalBrut INT;
	DECLARE @BrutImpozabil INT;
	DECLARE @CAS_suma INT;
	DECLARE @CASS_suma INT;
	DECLARE @Impozit_suma INT;
	

	SELECT @Impozit = Impozit, @CAS = CAS, @CASS = Cass FROM Parametrii

	SELECT @SalariuBaza = SalariuBaza, @ProcentSpor = ProcentSpor, @PremiiBrute = PremiiBrute, @Retineri = Retineri FROM Salariati 
	WHERE Nr_crt = @SalariatId

	SELECT @TotalBrut = CAST(@SalariuBaza * (1 + @ProcentSpor/100) + @PremiiBrute AS INT);
	SELECT @CAS_suma = CAST(@TotalBrut * @CAS AS INT);
	SELECT @CASS_suma = CAST(@TotalBrut * @CASS AS INT); 
	SELECT @BrutImpozabil = @TotalBrut - @CAS_suma - @CASS_suma;
	SELECT @Impozit_suma = CAST(@BrutImpozabil * @Impozit AS INT);
	
	UPDATE Salariati SET
		TotalBrut = @TotalBrut,
		CAS = @CAS_suma,
		CASS = @CASS_suma,
		BrutImpozabil = @BrutImpozabil,
		Impozit = @Impozit_suma,
		ViratCard = @TotalBrut - @CAS_suma - @CASS_suma - @Retineri - @Impozit_suma
	WHERE Nr_crt = @SalariatId

END
GO
