# Desafio da Compra de Chocolates

Você está em uma loja de chocolates onde cada tipo de chocolate tem um custo diferente. Você deseja comprar exatamente dois tipos de chocolates, mas quer gastar a maior quantidade do seu dinheiro sem ultrapassá-lo.

## Tarefa

Escreva um método chamado `BuyChoco` que execute a seguinte função:

- Recebe um array de inteiros `chocolates`, onde cada elemento representa o custo de um tipo de chocolate diferente, e um inteiro `money`, que é a quantidade de dinheiro que você tem para gastar.
- Você deve comprar exatamente dois chocolates.
- O método deve retornar a quantidade de dinheiro que restará após a compra. Se você não puder comprar dois chocolates sem exceder a quantidade de dinheiro que tem, você simplesmente não compra e retorna a quantidade total de dinheiro.

### Considere que:

- Você não pode comprar o mesmo tipo de chocolate duas vezes.
- O custo dos dois chocolates deve ser o mais próximo possível da quantidade de dinheiro disponível, sem excedê-lo.

## Solução

```csharp
public class Solution {
    public int BuyChoco(int[] chocolates, int money) {
        int minCost = int.MaxValue;

        int qntChocolates = chocolates.Length;

        for (int firstChoc = 0; firstChoc < qntChocolates; firstChoc++) {
            for (int secChoc = firstChoc + 1; secChoc < qntChocolates; secChoc++) {

                int cost = chocolates[firstChoc] + chocolates[secChoc];
                
                if (cost <= money && cost < minCost) {
                    minCost = cost;
                }
            }
        }

        return minCost <= money ? money - minCost : money;
    }
}

## Exemplo

```csharp
int[] chocolates = {1, 3, 2, 5, 4};
int money = 6;
Solution sol = new Solution();
int remainingMoney = sol.BuyChoco(chocolates, money); // Retorna 0, pois 5 (custo do chocolate mais caro) + 1 (custo do chocolate mais barato) = 6, que é igual ao dinheiro disponível. Assim, o dinheiro que restará é 6 - 6 = 0.
