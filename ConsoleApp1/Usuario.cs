public class Usuario
{

    public string nome { get; set; }
    public string sobrenome { get; set; }
    public int idade { get; set; }
    public string senha { get; set; }

    public string ExibirDados()
    {
        return $"Nome: {nome} {sobrenome} - Idade: {idade} anos - Senha: {senha}";
    }

}