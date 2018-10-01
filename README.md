# Injeção de Dependencia

Injeção de dependência é um dos padrões de desenvolvimento abordado nos Design Patterns, utilizado para o desenvolvimento de sistemas com baixo nível de acoplamento entre seus módulos.


## Simple injector

**[Simple injector](https://simpleinjector.org/documentation)** é uma biblioteca de injeção de dependência, com ele é muito mais fácil implementar o padrão de injeção de dependência em .NET 4+ que suporta o Silverlight, o Windows Phone, o Windows 8, incluindo os aplicativos Universal e o Mono. Simple Injector é facilmente integrado com frameworks como Web API, MVC, WCF, ASP.NET.

## Como funciona

A idéia geral por trás do Injetor Simples (ou de qualquer biblioteca DI) é que você projeta seu aplicativo em torno de componentes fracamente acoplados usando o padrão Injeção de Dependência enquanto adere ao Princípio de Inversão de Dependência.

## Como utilizar

Primeiramente, a aplicação deverá aderir o Princípio de Inversão de Dependência, dessa forma, teremos uma aplicação com baixo acoplamento e alta coesão.

Considerando que a aplicação está nessas condições, então apenas precisamos registrar a dependencias, como feito no arquivo [DependencyConfig.cs](https://github.com/MarcosMota/OrderOfService/blob/2-InjecaoDependecia/OrderService.WebApi/App_Start/README.md)

``` 
container.Register<[Interface], [Concreta]>();
```
Após essa configuração, não preciso mais instanciar a classe, pois o Simple Injector irá cuida de instaciar para nós. Por Exemplo:

```
 var obj = container.GetInstance<[Interface]>();
 obj.Action();
 ```
