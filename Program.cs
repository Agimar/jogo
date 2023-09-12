using System;

Console.WriteLine($"\n{DateTime.Now}\n");

do{
	int i, sorteio, numDigitado;
	string suaTentiva;

	Random numAleatorio = new Random();
	sorteio = numAleatorio.Next(1, 101);

	Console.WriteLine("========================================");
	Console.WriteLine("\nO jogo baseia-se em adivinhar o número que o computador sorteou entre 1 a 100, ganha quem adivinhar o número com a menor vezes de tentativas\n");
	Console.WriteLine("========================================");
	
	i = 0;
  do{

		Console.Write("\nDigite um número: ");
		numDigitado = Convert.ToInt16(Console.ReadLine());

		if (numDigitado > sorteio)
		{
			suaTentiva = "Numero digitado é maior que número sorteado";
		} else {
			suaTentiva = "Numero digitado é menor que número sorteado";
		}

		Console.WriteLine(suaTentiva);

		i++;
		Console.WriteLine("Qtide de tentativas: " + i);
		Console.WriteLine("\n====================");

	} while (sorteio != numDigitado);

		Console.WriteLine("\nAcertou o número sorteado: " +sorteio);
		Console.WriteLine("Foram " +(i - 1)+ " tentativas");

		Console.WriteLine("\n====================");
		Console.Write("\nDeseja continuar a jogar? s/n ");

} while (Console.ReadLine() == "s");