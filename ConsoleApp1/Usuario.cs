public class Usuario
{

    public string nome { get; set; }
    public string sobrenome { get; set; }
    public string idade { get; set; }
    public string senha { get; set; }

    public int ExibirDados()
    {
    _listarReg:
        Console.WriteLine("\nDeseja listar os registros?\n[S] Sim \n[N] Não");
        string opcListar = Console.ReadLine().ToUpper();

        if (opcListar != "S" && opcListar != "N")
        {
            Console.WriteLine("\nERRO 004: Opção escolhida é inválida! Tente novamente!");
            goto _listarReg;
        }
        else if (opcListar == "N")
            return 0;
        else
            return 1;
    }

}