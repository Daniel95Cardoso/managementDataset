CREATE PROCEDURE verificar_credenciais
(
	@nome_utilizador varchar(50),
	@password varchar(50)
)
AS
	BEGIN
		SELECT '#' 
		FROM [dbo].[Login]
		WHERE [nome_utilizador] = @nome_utilizador
		AND [password] = @password
	END