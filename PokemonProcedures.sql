CREATE PROCEDURE uspPokemonListar
AS
BEGIN
	SELECT * FROM Pokemon
	ORDER BY Pokemon.Id
END
GO

CREATE PROCEDURE uspPokemonInsertar (
	@Id int,
	@Nombre varchar(100),
	@Categoria varchar(50),
	@Peso decimal,
	@Altura decimal,
	@Habilidad varchar(50),
	@Descripcion varchar(300)
)
AS
BEGIN
	INSERT INTO Pokemon 
	(Id, Nombre, Categoria, Peso, Altura, Habilidad, Descripcion)
	VALUES (@Id, @Nombre, @Categoria, @Peso,
	@Altura, @Habilidad, @Descripcion)
END
GO

CREATE PROCEDURE uspPokemonEditar (
	@Id int,
	@Nombre varchar(100),
	@Categoria varchar(50),
	@Peso decimal(18,2),
	@Altura decimal(18,2),
	@Habilidad varchar(50),
	@Descripcion varchar(300)
)
AS
BEGIN
	UPDATE Pokemon
	SET
		Nombre = @Nombre,
		Categoria = @Categoria,
		Peso = @Peso,
		Altura = @Altura,
		Habilidad = @Habilidad,
		Descripcion = @Descripcion
	WHERE Id = @Id 
END
GO

CREATE PROCEDURE uspPokemonEliminar (
	@Id int
)
AS
BEGIN
	DELETE FROM Pokemon
	WHERE Id = 9 
END
GO

CREATE PROCEDURE uspPokemonObtener (
	@Id int
)
AS
BEGIN
	SELECT * FROM Pokemon
	WHERE Id = @Id 
END
GO

	ALTER TABLE Pokemon_Debilidad
	DROP CONSTRAINT FK_PokId_PDPId;

	ALTER TABLE Pokemon_Debilidad
	ADD CONSTRAINT FK_PokId_PDPId FOREIGN KEY (IdPokemon)
	REFERENCES Pokemon (Id)
	ON DELETE CASCADE;