# Arquitetura em camadas

Arquitetura em camadas é um padrão onde separa a aplicação por responsabilidade, com essa simples divisão se consegue facilitar a compreensão, manutenção, confiabilidade entre outros benefícios.​

Esse projeto foi dividido em 3 camadas:
- **[OrderService.WebApi](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.WebApi): **Camada responsavel por expor as regras de negócio.

- **[OrderService.Business](https://github.com/MarcosMota/OrderOfService/tree/1-ArquiteturaCamadas/OrderService.Business): **Projeto que contem duas camadas,uma responsavel pelas  validações e regras de negócio e outra pela manipulação de Dados