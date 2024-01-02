public class Solution {
	public int BuyChoco(int[] chocolates, int money) {
		int minCoast = int.MaxValue;

		int qntchocolates = chocolates.Length;

		for (int firstChoc = 0; firstChoc < qntchocolates; firstChoc++)
		{
			for (int secChoc = firstChoc + 1; secChoc < qntchocolates; secChoc++)
			{

				int cost = chocolates[firstChoc] + chocolates[secChoc];
				
				if (cost <= minCoast)
				{
					minCoast = cost;
				}
			}
		}

		return minCoast <= money ? money - minCoast : money;
	}
}