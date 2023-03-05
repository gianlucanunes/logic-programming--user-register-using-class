/*
 * 
 * 
 *      Atividade utilizando classes e conceitos estudados durante as aulas para criação de registros
 * 
 * 
 */


List<Usuario> info = new List<Usuario>();

string opcIn = "S";


Console.WriteLine("\n------------------\n|    Registro    |\n------------------\n");

// Loop while para o usuário registrar mais de um registro caso ele queira.
while (opcIn == "S")
{

// Pedindo ao usuário para que este preencha as informações.
    _reg:
    Usuario obj = new Usuario();
    Console.Write("\nPreencha as informações abaixo para completar o registro.\n");
    Console.Write("Nome: ");
    obj.nome = Console.ReadLine();

    Console.Write("Sobrenome: ");
    obj.sobrenome = Console.ReadLine();

    _idade:
    Console.Write("Idade: ");

    int id;
    if (int.TryParse(Console.ReadLine(), out id))
        obj.idade = id;
    else
    {
        Console.WriteLine("\nValor inválido! Tente novamente!\n");
        goto _idade;
    }

    _senha:
    Console.Write("Senha (6 dígitos): ");
    obj.senha = Console.ReadLine();

    if (obj.senha.Length != 6)
    {
        Console.WriteLine("\nA senha não possui 6 dígitos! Tente novamente!\n");
        goto _senha;
    }




    // Caso tudo esteja certo, armazena as informações dentro da lista.
    info.Add(obj);
    Console.WriteLine("\nUsuário cadastrado com sucesso!\n");


// Confere se o usuário deseja adicionar um novo registro. Caso sim, ele é mandado para o início onde deverá preencher novas informações.
    _addReg:
    Console.WriteLine("\nDeseja adicionar um novo registro?\n[S] Sim\n[N] Não\n");
    string opc = Console.ReadLine().ToUpper();

    if (opc != "S" && opc != "N")
    {
        Console.WriteLine("\nERRO 004: Opção escolhida é inválida! Tente novamente!");
        goto _addReg;
    }

    else if (opc == "S")
        goto _reg;

    else
    {
        opcIn = "N";
        // Calcula o total de registros.
        int totalReg = info.Count();

        Console.WriteLine($"\nA coleção possui um total de {totalReg} registros.\n");


    // Exibe ou não os dados para o usuário.
    _listarReg:
        Console.WriteLine("\nDeseja listar os registros?\n[S] Sim \n[N] Não");
        string opcListar = Console.ReadLine().ToUpper();

        if (opcListar != "S" && opcListar != "N")
        {
            Console.WriteLine("\nERRO 004: Opção escolhida é inválida! Tente novamente!");
            goto _listarReg;
        }

        else if (opcListar == "S")
        {
            foreach (var item in info)
            {
                Console.WriteLine(item.ExibirDados());
            }
        }

        break;
    }

}

Console.WriteLine("\nTecle espaço para encerrar...");
Console.ReadKey();







