using System;
using Section12.Contracts.Entities;
using Section12.Contracts.Services;
using System.Globalization;

namespace Section12
{
	class ProgramContract 
	{
		static void Main(string[] args)
		{

			//string teste = "26/01/2022";
            //Console.WriteLine(teste);
            //Console.WriteLine(teste.Substring(3,2));
			//.Substring(int startindex, int length)
			//N o método Substring é necessário passar a posição inicial e, a partir desta posição, o comprimento que deve ter.
			
			
			Console.WriteLine("Enter contract data");
			
			Console.Write("Number:");
			int number = int.Parse(Console.ReadLine());
			
			Console.Write("Date (dd/MM/yyyy):");
			DateTime date = DateTime.Parse(Console.ReadLine());

			Console.Write("Contract value: ");
			double totalValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

			Console.WriteLine("Enter number of installment: ");
			int numberInstallments = int.Parse(Console.ReadLine());

			//Criando um objeto de Contract
			Contract contract = new Contract(number, date, totalValue);

			DateTime dueDate;
			for (int i = 0; i < numberInstallments; i++)
			{
				//Aqui eu irei passar as datas de acordo com o prazo
				// Se for 3 parcelas e no mês 06/2022
				// 1°P: 07/2022  + juros + taxa
				// 2°P: 08/2022  + juros + taxa
				// 3°P: 09/2022  + juros + taxa

				//Cada amount receberá contract.paymentFee + contrat.interest
				//Cada montante receberá o valor da taxa de pagammento
				//acrescido da taxa de juros.
			
            }

			contract.installments.Add(new Installment(dueDate, (totalValue/numberInstallments)));


			Console.WriteLine("----------Installments-----------");

			


		}
	}

}