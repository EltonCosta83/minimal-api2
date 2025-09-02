Projeto de API de Gerenciamento de Veículos
Descrição
Este projeto é uma API em .NET Minimal que oferece um conjunto de funcionalidades para gerenciamento de veículos, incluindo autenticação de administradores. Ele foi construído seguindo 
boas práticas de design, separando a lógica de validação de dados (DTOs) das entidades de domínio e priorizando a segurança e a clareza.

Tecnologias Utilizadas
.NET 8

Minimal API

Entity Framework Core (para persistência de dados)

Data Annotations (para validação do modelo)

Estrutura do Projeto
O projeto é organizado em namespaces claros para separar as responsabilidades:

MinimalApi.Dominio.Entidades: Contém as classes que representam os modelos de dados da aplicação, mapeados para o banco de dados.

Administrador: Entidade para a gestão de usuários com diferentes perfis. A senha é armazenada como um hash para segurança.

Veiculo: Entidade que representa os dados de um veículo na base de dados.

MinimalApi.DTOs: Contém os Data Transfer Objects (DTOs), utilizados para a transferência de dados entre a API e o cliente. Eles são focados na validação dos dados de entrada.

LoginDTO: Usado para receber as credenciais de e-mail e senha no endpoint de login, com validações obrigatórias.

VeiculoDTO: Usado para criar ou atualizar veículos, com validações de dados rigorosas (como a faixa de ano).

Funcionalidades da API
Com base nos DTOs e entidades, os seguintes endpoints podem ser implementados:

POST /login: Endpoint para autenticação de administradores. Espera um LoginDTO no corpo da requisição.

POST /veiculos: Adiciona um novo veículo à base de dados. Requer autenticação e valida os dados com VeiculoDTO.

GET /veiculos: Retorna uma lista de todos os veículos cadastrados.

GET /veiculos/{id}: Retorna os detalhes de um veículo específico.

PUT /veiculos/{id}: Atualiza os dados de um veículo.

DELETE /veiculos/{id}: Remove um veículo da base de dados.

Decisões de Design e Melhorias
Este projeto incorpora as seguintes boas práticas de desenvolvimento:

Separação de Preocupações: O uso de DTOs (VeiculoDTO, LoginDTO) para validação de entrada garante que a lógica de validação esteja separada das entidades de domínio, 
tornando o código mais limpo e modular.

Segurança da Senha: O uso de SenhaHash para armazenar senhas no banco de dados é uma medida de segurança fundamental para proteger as credenciais dos usuários.

Validação Robusta: As anotações de dados ([Required], [StringLength], [Range], [EmailAddress]) garantem que os dados processados pela API sejam sempre válidos, 
com mensagens de erro claras e personalizadas.

C# Moderno: A utilização de records para os DTOs aproveita os recursos modernos do C#, proporcionando concisão e segurança de tipo.
