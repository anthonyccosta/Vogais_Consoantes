// faça um vetor de caracteres de 10 posiçoes e imprima os seguintes itens a) somente as vogais b) somente as consoantes

        char[] caracteres = new char[10];
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
        int impar = 0;

// Leitura dos 10 caracteres
for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º caractere: "); // pede para digitar o primeiro valor que vai ser guardado na variavel i
            caracteres[i] = Convert.ToChar(Console.ReadLine()); 
        }

        // vogais
        Console.WriteLine("\nVogais:");
        for (int i = 0; i < 10; i++)
        {
            if (caracteres[i] % 2 == 0) //se o valor que entrou no i acabar na divisao por 0, par
            {
                Console.WriteLine(caracteres[i]);
            }
}       

// consoantes
Console.WriteLine("\nConsoantes:");
        for (int i = 0; i < 10; i++)
        {
            if (caracteres[i] % 2 != 0) //se ouver um valor final difrente de 0 é impar
            {
                Console.WriteLine(caracteres[i]);
                impar++; // aumenta um a um se houver mais valores impares
            }
}
Console.ReadLine();
