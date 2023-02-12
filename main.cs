using System;

class guessTheNum
{
    static void Main()
    {
        char diff='$';
        char replay;
        string dificuldade;
        int tentativas;
        int aux;
        int num = 0;
        int secretNum;

        Random random = new Random();

        inicio:
        
        char aux2 = '$';
        Console.Clear();

        Console.WriteLine("\n\n   ~~ Adivinhe o número secreto ~~");
        Console.Write("\n\n    Digite a dificuldade do jogo:  ");

        if( diff == '#' )
        {
            Console.Write("[ INSIRA UM VALOR VÁLIDO ]");
        }

        Console.WriteLine("\n\n    [ 1 ] - Fácil");
        Console.WriteLine("    [ 2 ] - Normal");
        Console.WriteLine("    [ 3 ] - Difícil");
        Console.WriteLine("    [ 4 ] - Impossível");
        Console.Write("\n    --> ");
        diff = char.Parse(Console.ReadLine());

        switch (diff)
        {
            case '1':
                secretNum = random.Next(1,16);
                dificuldade = "Fácil";
                aux = 15;
                tentativas = 5;
                break;
            case '2':
                secretNum = random.Next(1,26);
                dificuldade = "Normal";
                aux = 25;
                tentativas = 5;
                break;
            case '3':
                secretNum = random.Next(1,51);
                dificuldade = "Difícil";
                aux = 50;
                tentativas = 7;
                break;
            case '4':
                secretNum = random.Next(1,101);
                dificuldade = "Impossível";
                aux = 100;
                tentativas = 10;
                break;
            default:
                diff = '#';
                goto inicio;
        }


        do
        {
            Console.Clear();

            Console.WriteLine("\n\n   ~~ Adivinhe o número secreto ~~");
            Console.WriteLine("\n\n    Dificuldade:  {0}   [1 - {1}]", dificuldade, aux);
            Console.WriteLine("  ____________________________________________");

            if (aux2 == '#')
            {
                if ( secretNum > num )
                {
                    Console.WriteLine("\n\n    [ O número secreto é maior que {0} ]", num);
                } else
                {
                    Console.WriteLine("\n\n    [ O número secreto é menor que {0} ]", num);
                }
            }

            Console.WriteLine("\n    Tentativas restantes: {0}", tentativas);

            Console.Write("\n    --> ");
            num = int.Parse(Console.ReadLine());

            if( num == secretNum )
            {
                Console.Clear();
                Console.WriteLine("\n\n    ~~ Adivinhe o número secreto ~~");
                Console.WriteLine(" ____________________________________________");
                Console.WriteLine("\n\n    Você ganhou!");
            } else
            {
                tentativas--;
                aux2 = '#';
            }

        } while( num != secretNum & tentativas > 0 );

        if ( num != secretNum )
        {
            Console.Clear();
            Console.WriteLine("\n\n    ~~ Adivinhe o número secreto ~~");
            Console.WriteLine(" ____________________________________________");
            Console.WriteLine("\n\n    Você perdeu!");
        }

        Console.Write("\n    Jogar novamente? [S/N]\n\n    --> ");
        replay = char.Parse(Console.ReadLine());

        switch(replay)
        {
            case 's':
            case 'S':
                goto inicio;
            default:
                break;
        }
    }
}