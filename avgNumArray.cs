using System;

public class SumNumbersArray
{
	public static void Main()
	{
		int i, j, total = 0;
		string stringValueArray;
		int [] valueArray = new int [100];
		float average;

		for (i = 0; i<valueArray.Length; i++)
		{
			Console.Out.Write("Enter a value or type 999 to exit: ");
			stringValueArray = Console.ReadLine();
			valueArray[i] = Convert.ToInt32(stringValueArray);

			if (valueArray[i] == 999)
				break;
		}

		Console.Out.Write("You entered:\n");

		for (j = 0; j < i; j++)
		{
			Console.Out.Write(valueArray[j] + "\n");
			total = total + valueArray[j];	
		}

		average = total/i;
		Console.Out.Write("\nThe average of these numbers is {0}\n", average);
	}
}