EXEC usp_GetAll 'AERO%'

GO

CREATE PROCEDURE usp_GetAll
(
	@filterByName NVARCHAR(100)
)
AS
BEGIN

	SELECT * FROM Artist
	WHERE Name LIKE @filterByName

END

GO

--CREATE OR ALTER
ALTER PROCEDURE usp_InsertArtist
@pName NVARCHAR(120)
AS

BEGIN
	
	IF NOT EXISTS(SELECT ArtistId FROM Artist WHERE Name = @pName)
	BEGIN 
		INSERT INTO Artist(Name)
		VALUES (@pName)

		SELECT SCOPE_IDENTITY()
		
	END
	ELSE
	BEGIN
		SELECT 0
	END
END

GO

CREATE PROCEDURE usp_UpdateArtist
@pName NVARCHAR(120),
@pId INT
AS

BEGIN

	IF NOT EXISTS(SELECT ArtistId FROM Artist 
		WHERE Name = @pName)
	BEGIN
		UPDATE Artist SET Name = @pName
		WHERE ArtistId = @pId
	END

END

CREATE PROCEDURE usp_DeleteArtist
@pId INT
AS

BEGIN

	DELETE FROM Artist 
	WHERE ArtistId = @pId


END

GO

CREATE PROCEDURE usp_InsertInvoice
(
@CustomerId INT, 
@InvoiceDate DATETIME, 
@BillingAddress NVARCHAR(70),
@BillingCity NVARCHAR(40), 
@BillingState NVARCHAR(40), 
@BillingCountry NVARCHAR(40), 
@BillingPostalCode NVARCHAR(10), 
@Total NUMERIC(10,2)
)
AS
BEGIN
	INSERT INTO Invoice(
		CustomerId, InvoiceDate, BillingAddress,
		BillingCity, BillingState, BillingCountry, 
		BillingPostalCode, Total
	)
	VALUES(
		@CustomerId, @InvoiceDate, @BillingAddress,
		@BillingCity, @BillingState, @BillingCountry, 
		@BillingPostalCode, @Total)


	SELECT SCOPE_IDENTITY()

END

GO

CREATE PROCEDURE usp_InsertInvoiceLine
(
@InvoiceId INT, 
@TrackId INT, 
@UnitPrice NUMERIC(10,2), 
@Quantity INT
)
AS
BEGIN

	INSERT INTO InvoiceLine
	(
		InvoiceId, TrackId, 
		UnitPrice, Quantity
	)
	VALUES(
		@InvoiceId, @TrackId, 
		@UnitPrice, @Quantity
	)
END

