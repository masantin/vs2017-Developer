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