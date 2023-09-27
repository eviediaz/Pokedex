CREATE PROCEDURE uspPokemonTipoListar
AS
BEGIN
	SELECT * FROM Pokemon_Tipo
	ORDER BY (SELECT NULL)
END
GO

CREATE PROCEDURE uspPokemonTipoInsertar (
	@IdPokemon int,
	@IdTipo int
)
AS
IF @IdTipo != -1
BEGIN
	INSERT INTO Pokemon_Tipo 
	(IdPokemon, IdTipo)
	VALUES (@IdPokemon, @IdTipo)
END
GO


ALTER PROCEDURE uspPokemonTipoEditar (
	@IdPokemon int,
	@IdTipo int,
	@OldIdTipo int
)
AS
BEGIN
	DELETE FROM Pokemon_Tipo 
	WHERE IdPokemon = @IdPokemon
	AND IdTipo = @OldIdTipo;

	IF(@IdTipo != 0)
		INSERT INTO Pokemon_Tipo
		VALUES (@IdPokemon,@IdTipo);
END
GO

CREATE PROCEDURE uspPTObtenerPokemon (
	@IdPokemon int
)
AS
BEGIN
	SELECT * FROM Pokemon_Tipo
	WHERE IdPokemon = @IdPokemon
END
GO
