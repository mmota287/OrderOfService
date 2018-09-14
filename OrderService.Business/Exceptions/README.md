# Exceptions

É importante fazer a separação das exceções do sistema e de negócio, dessa maneira, realizamos o tratamento das regras de negócio utilizando a classe BusinessException que é herdada de Exception. 

```
public void validate(Pessoa pessoa){
	//carga horaria nao pode ultrapassar 9h
	if (pessoa.getCargaHoraria() > 9) {
		throw new BusinessException("Carga horaria ultrapassou 9h");
	}
}
```