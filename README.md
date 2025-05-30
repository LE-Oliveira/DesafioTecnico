💼 Desafio Técnico - Controle de Produtos e Estoque

📌 Como Participar - Faça um fork deste repositório em sua conta do GitHub.
  Desenvolva a solução no seu fork.
  Após finalizar, abra um Pull Request (PR) para este repositório.
  Aguarde o feedback da equipe.

🎯 Objetivo - Desenvolver uma aplicação full stack com:
Backend em C# utilizando ASP.NET Core Web API
Frontend em Vue.js com consumo da API
Controle de produtos e movimentações de estoque (entradas e saídas)
Validação de regras de negócio como saldo insuficiente

🧠 Funcionalidades
1. Cadastro de Produto contendo os seguintes campos: Código, Descrição, Tipo de Produto (Eletrônico, Eletrodoméstico, Móvel), Valor do Fornecedor,
 Quantidade em Estoque (valor inicial)

4. Entrada de Estoque
Seleção de produto existente,
Campo para quantidade a adicionar,
Atualização do valor do fornecedor,
Chamada à API para registrar a entrada

5. Saída de Estoque
Seleção de produto,
Campo para quantidade de saída,
Campo para valor de venda,
Validação de saldo disponível,
Registro da movimentação via API

🧪 Regras de Negócio - Não permitir saída de estoque com quantidade maior do que o disponível
Toda saída deve registrar:
Valor de Venda,
Data da Movimentação,
Quantidade

💾 Armazenamento - Use o banco de dados de sua preferência: PostgreSQL, MySQL ou SQL Server.

🧰 Sugestão de Telas (Frontend Vue.js) - Tela Principal com Menu de Navegação
Cadastro de Produto,
Movimentação de Estoque com abas,
Entrada,
Saída,
Histórico de Movimentações

📝 Avaliação - Critérios sugeridos:
Organização do código (separação clara entre backend e frontend)
Adoção de boas práticas (ex: camadas de serviço, DTOs, controllers no backend)
Validações de dados no backend e frontend
Documentação da API (Swagger ou equivalente)
Clareza na estrutura de componentes Vue.js
UX/UI básica mas funcional
Tratamento de erros e mensagens amigáveis
