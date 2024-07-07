public class Funcionario_Meio_Periodo : Funcionario
{
    private double Salario_Por_Hora;
    private double Horas_Trabalhadas;

    public Funcionario_Meio_Periodo(string Nome, int Matricula, double Salario_Por_Hora, double Horas_Trabalhadas) : base(Nome, Matricula)
    {
        this.Salario_Por_Hora = Salario_Por_Hora;
        this.Horas_Trabalhadas = Horas_Trabalhadas;
    }

    public override double Calcular_Salario()
    {
        return Salario_Por_Hora * Horas_Trabalhadas;

    }

    public override void Exibir_Informacoes()
    {
        double Salario_Mensal = Calcular_Salario();
        Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário Mensal: R${Salario_Mensal} e sou um Funcionário de meio pariodo");

    }

    public double Calcular_Bonus()
    {
        return Calcular_Salario() * 0.05;
    }
}