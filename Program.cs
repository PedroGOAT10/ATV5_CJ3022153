namespace ATV5_CJ3022153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 0 ver o Exemplo da Lousa");
            Console.WriteLine("Digite 1 para Exercico 1");
            Console.WriteLine("Digite 2 para Exercico 2");
            Console.WriteLine("Digite 3 para Exercico 3");
            Console.WriteLine("Digite 4 para Exercico 4");
            Console.WriteLine("Digite 5 para Exercico 5");
            Console.WriteLine("Digite 6 para Exercico 6");
            Console.WriteLine("Digite 7 para Exercico 7");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:

                    int a, temp;
                    int soma = 0;

                    for (a = 0; a < 2; a++)
                    {
                        Console.WriteLine("Digite um valor");

                        temp = int.Parse(Console.ReadLine());
                        if (temp < 0)
                            break;
                        soma = soma + temp;
                    }
                    Console.WriteLine("A média é {0}, soma", soma / 3);

                    break;

                case 1:

                    Console.WriteLine("Digite um numero");
                    int numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números de 1 até o número digitado:");

                    for (int i = 1; i <= numero; i++)
                    {
                        Console.WriteLine(i);

                    }
                    break;

                case 2:
                    Console.WriteLine("Digite um número inteiro:");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1 até o número Escrito:");

                    for (int i = 2; i <= n; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case 3:
                    int nu;


                    Console.WriteLine("Digite um número inteiro menor que 1000:");
                    nu = int.Parse(Console.ReadLine());

                    if (nu >= 1000)
                    {
                        Console.WriteLine("O número digitado deve ser menor que 1000. Tente novamente.");
                    }
                    Console.WriteLine($"Números pares de 1000 até {nu}:");

                    for (int b = 1000; b <= nu; b++)
                    {
                        if (b % 2 == 0)
                        {
                            Console.WriteLine(b);
                        }
                    }
                    break;

                case 4:
                    int somaPositivos = 0;

                    Console.WriteLine("Digite uma sequência de números inteiros (digite um número negativo para parar):");


                    {
                        Console.Write("Digite um número inteiro: ");
                        int num = int.Parse(Console.ReadLine());

                        if (num < 0)
                        {
                            break;
                        }

                        if (num > 0)
                        {
                            somaPositivos += num;
                            Console.WriteLine("Número positivo adicionado. Soma atual dos positivos: {somaPositivos}");
                        }
                    }

                    Console.WriteLine("A soma dos números positivos é: {0}", somaPositivos);
                    break;


                case 5:

                    Console.Write("Digite um número inteiro: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Os divisores do número {n1} são:");

                    for (int d = 1; d <= n1; d++)
                    {
                        if (n1 % d == 0)
                        {
                            Console.WriteLine(d);

                        }
                    }
                    break;

                case 6:

                    int quantidadeNumeros = 10;
                    int[] numeros = new int[quantidadeNumeros];
                    int maior = int.MinValue;
                    int menor = int.MaxValue;

                    Console.WriteLine("Digite 10 números:");

                    for (int i = 0; i < quantidadeNumeros; i++)
                    {
                        Console.Write("Número {i + 1}: ");
                        numeros[i] = int.Parse(Console.ReadLine());

                        if (numeros[i] > maior)
                        {
                            maior = numeros[i];
                        }

                        if (numeros[i] < menor)
                        {
                            menor = numeros[i];
                        }
                    }

                    Console.WriteLine("O maior número digitado foi: {0} ", maior);
                    Console.WriteLine("O menor número digitado foi: {0}", menor);
                    break;

                case 7:

                    int somaPares = 0;
                    int somaImpares = 0;

                    Console.WriteLine("Digite uma sequência de números. Digite 0 para encerrar.");

                    {
                        Console.Write("Digite um número: ");
                        int n2 = int.Parse(Console.ReadLine());

                        if (n2 == 0)
                        {
                            break;
                        }

                        if (n2 % 2 == 0)
                        {
                            somaPares += n2;
                        }
                        else
                        {
                            somaImpares += n2;
                        }
                    }

                    Console.WriteLine("A soma dos números pares é: {0}", somaPares);
                    Console.WriteLine("A soma dos números ímpares é: {0}", somaImpares);
                  
                    break;


            }
        }
    }
}

