
string usuarioValido = "M";
string senhaValida = "1";
bool loginValido = false;
char resposta;
bool encerrarPrograma = false;

string[] numvoo = new string[1];
string[] nome = new string[1];
string[] datavoo = new string[1];
string[] horario = new string[1];
string[] origem = new string[1];
string[] destino = new string[1];

int contador = 0;



Console.WriteLine(@"      Linhas Aéreas Brasileiras     ");
Console.WriteLine("------------------------------------");
 
 
 Console.Write("Digite seu usuário: ");
 string usuario = (Console.ReadLine()) .ToUpper ();

while (usuario != usuarioValido)     
    {
    Console.Clear();
    Console.WriteLine(@$"                      ACESSO  NEGADO !                                      ");
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine(@"       Erro: O nome de usuário digitado está incorreto.Tente novamente"       );
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.Write("Digite seu usuário: ");
    usuario = (Console.ReadLine()) .ToUpper ();
    }
 

 Console.WriteLine();

do{

 string senha = "";
 Console.Write("Digite sua senha de 6 caracteres: ");
 ConsoleKeyInfo keyInfo;
 
    do
    {
        keyInfo = Console.ReadKey(true);
        // Skip if Backspace or Enter is Pressed
        if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
        {
            senha += keyInfo.KeyChar;
            Console.Write("*");
        }
        else
        {
            if (keyInfo.Key == ConsoleKey.Backspace && senha.Length > 0)
            {
                // Remove last charcter if Backspace is Pressed
                senha = senha.Substring(0, (senha.Length - 1));
                Console.Write("\b \b");
            }
        }
    }
    // Stops Getting Password Once Enter is Pressed
    while (keyInfo.Key != ConsoleKey.Enter);



if  (senha == senhaValida)
    {
    loginValido = true;
    }

   else
    {
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine(@$"                      ACESSO  NEGADO !                                      ");
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine(@"           Erro: A senha digitada está incorreta.Tente novamente"              );
    Console.WriteLine("-------------------------------------------------------------------------------"); 
    }


} while (loginValido == false);

do
{
Console.Clear();      
Console.WriteLine (@$"
BEM VINDO {usuario}
____________________________________________________________________
|                      LINHAS AÉREAS BRASILEIRAS                   |
|------------------------------------------------------------------|
|                     ESCOLHA UMA OPÇÃO ABAIXO                     |
|------------------------------------------------------------------|
|                                       |                          |
|          CADASTRAR PASSAGEM           |           [1]            |
|           EXCLUIR PASSAGENS           |           [2]            |
|            LISTAR PASSAGENS           |           [3]            |
|            SAIR DO PROGRAMA           |           [0]            |
|__________________________________________________________________|
");

 Console.Write("Digite o número da opção desejada: ");

     switch (Console.ReadLine())
    {
        case "1":
        Console.Clear();      
        Console.WriteLine($"*****CADASTRO DE VOO*****");
            
          do
                    {
                        for (var i = 0; i < 1; i++)
                        {
                        Console.WriteLine();
                        Console.WriteLine($"Digite número do voo:");
                        numvoo[i] = Console.ReadLine();
                        
                        Console.WriteLine();
                        Console.WriteLine($"Digite o nome do passageiro {i+1}º:");
                        nome[i] = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"Digite data do voo: (DD/MM/AAAA)");
                        datavoo[i] = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"Digite horário do voo:");
                        horario[i] = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine($"Digite o aeroporto de origem:");
                        origem[i] = Console.ReadLine();
                        
                        Console.WriteLine();
                        Console.WriteLine($"Digite o aeroporto de destino:");
                        destino[i] = Console.ReadLine();
                        }

                        contador ++;

                        Console.WriteLine();
                        Console.WriteLine($"Deseja cadastrar outra passagem [S/N] ?");
                        resposta = char.Parse(Console.ReadLine() .ToUpper ()) ;
                        
                    } while (resposta == 'S');

                        break;


        case "2":
         Console.Clear();
            Console.WriteLine($"Your result:");
            
            break;

        case "3":
        
            if (contador < 1)
                {
                   Console.WriteLine($"Nenhum voo encontrado !");
                }

                else
                {
                        for (var i = 0; i < 1; i++)
                        {
                        Console.WriteLine(@$"
                        Número do voo: {numvoo[i]}
                        Nome do passageiro: {nome[i]}
                        Data: {datavoo[i]}
                        Horário: {horario[i]}
                        Origem: {origem[i]}
                        Destino: {destino[i]}
                        ");
                        }

                    Console.Write("Aperte <Enter> para sair... ");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) {}
                }

         break;             

        case "0":
            Console.WriteLine();
            Console.WriteLine("O programa foi encerrado com sucesso");
            Environment.Exit(0);
            encerrarPrograma = true;
            break;

        default:
            Console.WriteLine($"ERRO");
            

            break;
        
    }


} while (encerrarPrograma == false);



