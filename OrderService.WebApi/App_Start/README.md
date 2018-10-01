
# Configurando a Injeção de Dependecia #

Como nossa aplicação está utilizando o principio de Inversão de Dependencia. Dessa maneira, é facil realizar a configuração do simple injector, como podemos ver abaixo:

## 1 - Iniciando ##
Instaciamos o container do Simple Injector e informamos o tipo do escopo que iremos utilizar. [Clique aqui para mais informações sobre escopos e tempo de vida de instancias](https://simpleinjector.readthedocs.io/en/latest/lifetimes.html#scoped)

```
var container = new Container();
container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
```
## 2 - Configurando ##
Neste ponto, vamos configururar as injeção de dependecia, para melhor entendimento, podem pensar assim.
" Quando chamar essa interface, chame essa classe concreta "

```
container.Register<OrderContext>(Lifestyle.Scoped);
container.Register<IOrderRepository, OrderRepository>();
container.Register<IOrderService, OrderService>();
container.RegisterWebApiControllers(config);
```
## 2 - Verificação ##
Após configurar, temos chamar esse metodo, que vai permitir o Simple gerar um grafo de todas as nossas dependencias.
```
container.Verify();
config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
```            

Essas configurações foram feitas no arquivo [DependencyConfig.cs](https://github.com/MarcosMota/OrderOfService/blob/2-InjecaoDependecia/OrderService.WebApi/App_Start/DependencyConfig.cs).
