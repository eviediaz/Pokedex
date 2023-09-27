CREATE PROCEDURE uspTipoObtener (
	@TipoId int
)
AS
BEGIN
	SELECT * FROM Tipo
	WHERE Id = @TipoId
END
GO

CREATE PROCEDURE uspTipoListar
AS
BEGIN
	SELECT * FROM Tipo
	ORDER BY Id
END
GO