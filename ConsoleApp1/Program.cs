/*
 * 
 * 
 *      Atividade utilizando classes e conceitos estudados durante as aulas para criação de registros
 * 
 * 
 */


Usuario user = new Usuario();
List<string> info = new List<string>();

int controle1 = 0;
int controle2 = 1;


Console.WriteLine("\n------------------\n|    Registro    |\n------------------\n");

// Loop while para o usuário registrar mais de um registro caso ele queira.
while (controle1 < controle2)
{

// Pedindo ao usuário para que este preencha as informações.
_reg:
    Console.Write("\nPreencha as informações abaixo para completar o registro.\n");
    Console.Write("Nome: ");
    user.nome = Console.ReadLine();

    Console.Write("Sobrenome: ");
    user.sobrenome = Console.ReadLine();

    Console.Write("Idade: ");
    user.idade = Console.ReadLine();

    Console.Write("Senha (6 dígitos): ");
    user.senha = Console.ReadLine();


    // Métodos para verificar a Idade e a Senha
    int VerificaIdade()
    {
        try
        {
            Convert.ToInt32(user.idade);
            return 1; ;
        }
        catch
        {
            return 0;
        }
    }

    int VerificaSenha()
    {
        if ((user.senha).Length != 6)
            return 0;
        else
            return 1;
    }


    // Verifica se a senha e/ou a idade fornecidas são válidas.
    if (VerificaIdade() == 0 && VerificaSenha() == 1)
    {
        Console.WriteLine("\nERRO 001: A idade fornecida não é um valor válido! Tente novamente.\n");
        goto _reg;
    }
    else if (VerificaIdade() == 1 && VerificaSenha() == 0)
    {
        Console.WriteLine("\nERRO 002: A senha fornecida não possui 6 dígitos! Tente novamente.\n");
        goto _reg;
    }
    else if (VerificaIdade() == 0 && VerificaSenha() == 0)
    {
        Console.WriteLine("\nERRO 003: A senha não possui 6 dígitos e a idade fornecida não é um valor válido! Tente novamente.\n");
        goto _reg;
    }


    // Caso tudo esteja certo, armazena as informações dentro da lista.
    info.Add(user.nome);
    info.Add(user.sobrenome);
    info.Add(user.idade);
    info.Add(user.senha);
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
    {
        controle1++;
        controle2++;
    }
    else break;

}


// Calcula o total de registros. Por que dividir por 4? Porque na lista, a cada 4 posições há um novo registro. Logo, quando você divide por 4, você calcula o total de registros existentes dentro da lista.
int totalReg = info.Count() / 4;

Console.WriteLine($"\nA coleção possui um total de {totalReg} registros.\n");


// Exibe ou não os dados para o usuário.
if (user.ExibirDados() == 1)
{
    Console.WriteLine();
    for (int posicao = 0; posicao < info.Count(); posicao = posicao + 4)
    {
        Console.WriteLine($"Nome: {info[posicao]} {info[posicao + 1]} - Idade: {info[posicao + 2]} - Senha: {info[posicao + 3]}");
    }
}
else
{
    Console.WriteLine("\nTecle espaço para encerrar...");
    Console.ReadKey();
}





