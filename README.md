# Sistema Registro de Serviços

Na aplicação real que inspirou essa API, não haveria necessidade de endpoints de atualização ou busca por ID. 
No entanto, para fins de portfólio, implementei o CRUD completo, a fim de demonstrar domínio das boas práticas no desenvolvimento de APIs REST

O Sistema de Registro de Serviços é uma API RESTful desenvolvida em C# com Entity Framework, projetada para gerenciar serviços de forma simples e organizada. A aplicação permite:
 - Cadastrar novos serviços com informações como placa do caminhão, quantidade de cubos trocados e valor total do serviço.

 - Listar todos os serviços cadastrados.

 - Buscar um serviço específico por ID, facilitando consultas pontuais.

 - Atualizar serviços existentes, garantindo que as informações estejam sempre corretas.

 - Remover serviços quando necessário, mantendo o banco de dados limpo.

## O sistema segue boas práticas de arquitetura, com camadas bem definidas: 

### Controller → Interface → Service → DbContext → Banco de Dados

Garantindo baixo acoplamento e facilidade de manutenção.
