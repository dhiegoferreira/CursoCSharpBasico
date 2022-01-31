using System;
using Section13.Contracts.Entities;
using Section13.Contracts.Services;
using System.Globalization;

namespace CursoCSharp.Section13
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
			int contractNumber = int.Parse(Console.ReadLine());

			Console.Write("Date (dd/MM/yyyy):");
			DateTime contractDate = DateTime.Parse(Console.ReadLine());

			Console.Write("Contract value:");
			double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Enter number of installment:");
			int months = int.Parse(Console.ReadLine());

			//Criando um objeto de Contract
			Contract contract = new Contract(contractNumber, contractDate, contractValue);

			//Criando um objeto do tipo ContractService e passando o objeto concreto com upcasting (PaypalService é uma classe concreta que
			//implementa a interface IOnlinePaymentService
			ContractService contractService = new ContractService(new PaypalService());

			contractService.ProcessContract(contract, months);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Installments");
			foreach(Installment installments in contract.installments)
            {
                Console.WriteLine(installments);

            }


		}
	}

}