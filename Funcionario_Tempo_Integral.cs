public class Funcionario_Tempo_Integral : Funcionario, IBonus{
    private double Salario_Mensal;
    public double Bonus;

    public Funcionario_Tempo_Integral(string Nome, int Matricula, double Salario_Mensal) : base(Nome, Matricula){
        this.Salario_Mensal = Salario_Mensal;
   }

   public override double Calcular_Salario(){
        return Salario_Mensal;
   }

   public override void Exibir_Informacoes(){
    Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário Mensal: R${Salario_Mensal} e sou um Funcionário Tempo Integral");
   }
   public double Calcular_Bonus(){
    return Salario_Mensal * 0.10;
   }
}