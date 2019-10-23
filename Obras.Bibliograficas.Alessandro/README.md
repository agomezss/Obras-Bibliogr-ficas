# Obras Bibliográficas - Backend

Projeto de back-end criado por **Alessandro Gomez**

[Linkedin](https://www.linkedin.com/in/alessandro-gomez/ "Linkedin")

O Projeto foi desenvolvido utilizando .NET Core 2.2 Web API.


## Rodar ambiente de desenvolvimento

Tenha instalado o **Dot Net Core 2.2 SDK e uma IDE (preferencialmente o Visual Studio 2019 Community Edition)**

Execute a aplicação no Visual Studio para subir a API

Será mostrado o Swagger para navegação na API com toda funcionalidade CRUD Funcional


## Testes

Foi criado um projeto de testes dentro da Solution com testes unitários para as regras de negócio dos nomes dos autores e foi criado um teste
de integração para a camada service que realiza todas operações crud utilizando um banco InMemory.


## Tecnologias

Utilizei uma arquitetura baseada em DDD, com uma camada de domínio rica, com as regras de nomes todas lá, utilizei o design pattern Strategy
para a familía de algoritmos que roda as regras em cima do nome dos autores, embora tenha chamado essa classe de provider.

Muito do DDD está presente na arquitetura, temos uma Infra Cross Cutting, temos uma camada de serviço orquestrando as chamadas.

Utilizei injeção de dependência para poder inverter o controle e depender de interfaces na camada de domínio e que a mesma não necessite saber
onde estão as implementações concretas.

Utilizei também padrão repositório com DbContext o qual tenho um "modo de teste" que posso fazer com que nunca uma transação seja comitada ou até mesmo
instanciar um banco InMemory completamente apartado do físico quando eu precise.

Utilizei o EFCore como ORM e não utilizei um banco físico, utilizei um banco de dados InMemory pela facilidade de uso e pelo fato de dispensar qualquer
configuração de instância para rodar a aplicação.

Na API, Optei por utilizar o swagger por facilitar muito a visualização de APIs e poder realizar uns testes práticos na arquitetura.

