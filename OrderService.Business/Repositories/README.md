# Repositórios

Classe que realiza a persistência das entidades se comunicando diretamente com o meio de acesso aos dados, é a unica classe que tem conhecimento do banco de dados.


**Observação:** Sempre precisamo criar uma abstração com as operações de manipulação de dados, nesse exemplo criamos uma interface com as operações. Dessa forma, todos os repositórios deverão ter os mesmos metodos.