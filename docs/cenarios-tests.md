# Cenários de Teste

## 1. Leilão com pelo menos um lance

- Dado um leilão com pelo menos um lance
- Quando o pregão/leilão termina
- Então o valor esperado é o maior valor dado e o cliente é o que deu o maior lance

## 2. Leilão sem lance nenhum

- Dado um leilão sem qualquer lance
- Quando o pregão/leilão termina
- Então o valor do lance ganhador é zero

## 3. Leilão finalizado recebe lance

- Dado leilão finalizado com X lances
- Quando leilão recebe nova oferta de lance
- Então a quantidade de lances continua sendo X
