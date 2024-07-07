public class Empresa
{
    public List<Funcionario> Lista_Funcionarios = new List<Funcionario>();

    public void Adicionar_Funcionario(Funcionario Funcionario)
    {
        Lista_Funcionarios.Add(Funcionario);
    }
    public void Remover_Funcionario(int Numero_Matricula)
    {
        for (int i = 0; i < Lista_Funcionarios.Count; i++)
        {

            if (Lista_Funcionarios[i].Matricula == Numero_Matricula)
            {
                Lista_Funcionarios.RemoveAt(i);
            }
        }
    }

    public void Exibir_Funcionario()
    {
        for (int i = 0; i < Lista_Funcionarios.Count; i++)
        {
            Lista_Funcionarios[i].Exibir_Informacoes();

            if (Lista_Funcionarios[i].Projetos.Count > 0)
            {
                Console.WriteLine($"Projetos: {string.Join(", ", Lista_Funcionarios[i].Projetos)}");
            }

            else
            {
                Console.WriteLine("Projetos: Nenhum Projeto");
            }
            Console.WriteLine();
        }
    }

}
