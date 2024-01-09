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



