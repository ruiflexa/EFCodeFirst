CREATE TABLE [dbo].[TB_Pessoa]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Pes_nmPessoa] VARCHAR(200) NULL, 
    [Pes_nrIdade] INT NULL, 
    [Pes_dtCadastro] DATETIME NULL, 
    [Pes_flAtivo] BIT NULL
)
