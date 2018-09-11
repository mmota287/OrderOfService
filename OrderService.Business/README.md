# Camada de Negócio

Tem a responsabilidade de interligar as regras de negócio para as camadas de apresentações, com troca de mensagem de modo confiável e flexível.​

Nesse projeto, utilizamos um projeto Class Lib e vamos implementar todos as regras de negócio de forma isolada.

**Responsabilidades**

 - **[Services](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.Business/Services):** Os services são todos os processos da nossa regra de negócio.

 - **[Exceptions](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.Business/Exceptions):** As exceções são importantes para separar exceções do sistema e exceções de negócio.
 
 - **[Entities](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.Business/Entities):** São objetos inspirados no mundo real que possui uma identidade e tem uma linha de continuidade.

 Nessa camada é de extrema importancia dominar os conceitos de orientação objeto, abaixo tem alguns artigos sobre OOP para aprimorar seus conhecimentos.

- [O que significa Orientação a objetos ?](http://www.macoratti.net/oo_conc2.htm)

- [Os 4 pilares da Programação Orientada a Objetos](https://www.devmedia.com.br/os-4-pilares-da-programacao-orientada-a-objetos/9264)


- [Conceitos e Exemplos – Polimorfismo: Programação Orientada a Objetos](https://www.devmedia.com.br/conceitos-e-exemplos-polimorfismo-programacao-orientada-a-objetos/18701)

- [Quando usar Interfaces?](http://www.mauda.com.br/?p=1077)

# Camada de Dados

Uma aplicação tem um ou mais repositórios de dados e a camada de dados tem a responsabilidade de manipular os dados dos repositórios. Essa camada só é conhecida pela camada de negócio, onde busca e envia dados para serem salvos.​

Nesse projeto, utilizamos um projeto Class Lib e vamos utilizar como fonte de dados um SQL Server Database File.

 - **[Context](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.Business/Context):** São o dominio das regras de negócio
 
 - **[Repositories](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.Business/Repositories/Orders):** Os repositórios são os responsaveis por acessar e persistir os dados no banco de dados. 

**Links:**

 - [DDD: Repository Implementation Patterns](https://lostechies.com/jimmybogard/2009/09/03/ddd-repository-implementation-patterns/)

 - [Projetando a camada de persistência da infraestrutura](https://docs.microsoft.com/pt-br/dotnet/standard/microservices-architecture/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design)

 