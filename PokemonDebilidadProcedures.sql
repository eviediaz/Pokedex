CREATE PROCEDURE uspPokemonDebilidadListar
AS
BEGIN
	SELECT * FROM Pokemon_Debilidad
	ORDER BY Pokemon_Debilidad.IdPokemon
END
GO

CREATE PROCEDURE uspPokemonDebilidadInsertar (
	@IdPokemon int,
	@IdDebilidad int
)
AS
IF @IdDebilidad != -1
BEGIN
	INSERT INTO Pokemon_Debilidad 
	(IdPokemon, IdDebilidad)
	VALUES (@IdPokemon, @IdDebilidad)
END
GO


ALTER PROCEDURE uspPokemonDebilidadEditar (
	@IdPokemon int,
	@IdDebilidad int,
	@OldIdDeb int
)
AS
BEGIN
	DELETE FROM Pokemon_Debilidad
	WHERE IdPokemon = @IdPokemon
	AND IdDebilidad = @OldIdDeb;

	IF(@IdDebilidad != -0)
		INSERT INTO Pokemon_Debilidad
		VALUES (@IdPokemon,@IdDebilidad);
END
GO

CREATE PROCEDURE uspPDObtenerPokemon (
	@IdPokemon int
)
AS
BEGIN
	SELECT * FROM Pokemon_Debilidad
	WHERE IdPokemon = @IdPokemon
END
GO