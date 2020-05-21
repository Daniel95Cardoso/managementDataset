-- FKeys
ALTER TABLE [dbo].[Encomendas]
ADD FOREIGN KEY ([fk_id_produto]) REFERENCES [dbo].[Produtos]([id_produtos]);
ALTER TABLE [dbo].[Encomendas]
ADD FOREIGN KEY ([fk_id_fornecedor]) REFERENCES [dbo].[Fornecedores]([id_fornecedores]);
ALTER TABLE [dbo].[DespContentor]
ADD FOREIGN KEY ([fk_id_moeda]) REFERENCES [dbo].[Moeda]([id_moeda]);
ALTER TABLE [dbo].[Produtos]
ADD FOREIGN KEY ([fk_moedas]) REFERENCES [dbo].[Moeda]([id_moeda]);
ALTER TABLE [dbo].[Vendas]
ADD FOREIGN KEY ([fk_id_cliente]) REFERENCES [dbo].[Clientes]([id_clientes]);
ALTER TABLE [dbo].[Vendas]
ADD FOREIGN KEY ([fk_id_produtos]) REFERENCES [dbo].[Produtos]([id_produtos]);
ALTER TABLE [dbo].[DespMensais]
ADD FOREIGN KEY ([fk_id_Funcionario]) REFERENCES [dbo].[Funcionario]([id_funcionario]);
ALTER TABLE [dbo].[DespMensais]
ADD FOREIGN KEY ([fk_id_Bens]) REFERENCES [dbo].[Bens]([id_bens]);
ALTER TABLE [dbo].[DespMensais]
ADD FOREIGN KEY ([fk_id_moeda]) REFERENCES [dbo].[Moeda]([id_moeda]);

drop table [dbo].[DespMensais]
