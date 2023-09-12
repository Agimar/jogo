using System;

Console.WriteLine($"\n{DateTime.Now}\n");

do{
	int i, sorteio, numDigitado;
	string suaTentiva;

	Random numAleatorio = new Random();
	sorteio = numAleatorio.Next(1, 101);

	i = 0;
	do{

		Console.Write("Digite um número: ");
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
		Console.WriteLine("====================");

	} while (sorteio != numDigitado);

	Console.WriteLine("Acertou o número sorteado: " +sorteio);
	Console.WriteLine("Foram " +(i - 1)+ " tentativas");

	Console.WriteLine("====================");
	Console.Write("Deseja continuar a brincadeira? s/n");

} while (Console.ReadLine() == "s");