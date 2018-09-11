# Camada de Comunicação

Tem a responsabilidade de interligar as regras de negócio para as camadas de apresentações, com troca de mensagem de modo confiável e flexível

Nesse projeto, utilizamos um projeto Web API para expor nossas regras de negócio. 

**Responsabilidades**

 - **Segurança:** Validar regras de autorização e autenticar quando preciso.

 - **Validação das Requisições:** Muitas vezes a camada de comunicação recebe dados de diferente formatos e estrutura, e não podemos alterar nosso projeto de camada de negócio apenas para satisfazer uma requisição da camada da apresentação.
 
 - **Processar Respostas:** A resposta para a camada de apresentação tem o mesmo caso da requisição, não pode ser acoplada a camada de negócio. Dessa forma, conseguimos unir varios retornos da camada de negócio e retornar em apenas uma resposta