public abstract class Funcionario
{
    public string Nome;

    public int Matricula;

    public List<string> Projetos = new List<string>();

    public Funcionario(string Nome, int Matricula)
    {
        this.Nome = Nome;
        this.Matricula = Matricula;
    }

    public abstract double Calcular_Salario();
    public abstract void Exibir_Informacoes();

    public void Adicionar_Projeto(string Projeto)
    {
        Projetos.Add(Projeto);
    }

    public void Adicionar_Projeto(List<string> Lista)
    {
        for (int i = 0; i < Lista.Count; i++)
        {
            Projetos.Add(Lista[i]);
        }
    }
}


