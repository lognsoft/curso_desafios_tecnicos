# Desafio de Programação: Encontrar o Maior Número em um Vetor

## Descrição
Escreva uma função em C# chamada `maiorNumeroVetor` que recebe um array de inteiros como argumento e retorna o maior número contido neste vetor. A função também deve imprimir o maior número encontrado com uma mensagem explicativa. Se o vetor estiver vazio, a função deve imprimir "Vetor vazio" e retornar 0.

### Entradas
- Um array de inteiros `vet`, que pode estar vazio.

### Saída
- A função imprime e retorna o maior número no array, ou imprime "Vetor vazio" e retorna 0 se o array não contiver elementos.

## Solução do Desafio

```csharp
int[] vet = new int[]{};

maiorNumeroVetor(vet);

int maiorNumeroVetor(int[] vet)
{
	if (vet.Length > 0)
	{
		int n = vet[0];

		for (int i = 1; i < vet.Length; i++)
		{
			if (vet[i] > n)
			{
				n = vet[i];
			}
		}

		Console.WriteLine(n + " Maior numero do vetor");
		return n;
	}
	else
	{
		Console.WriteLine("Vetor vazio");
		return 0;
	}
}
