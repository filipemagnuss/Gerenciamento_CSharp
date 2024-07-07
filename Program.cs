Empresa Empresa = new Empresa();

while (true) 
{
    // Exibe o menu de opções para o usuário
    Console.WriteLine("1. Adicionar um funcionário de tempo integral");
    Console.WriteLine("2. Adicionar um funcionário de meio período");
    Console.WriteLine("3. Remover um funcionário");
    Console.WriteLine("4. Exibir informações de todos os funcionários");
    Console.WriteLine("5. Adicionar projeto a um funcionário");
    Console.WriteLine("9. Sair do programa");

    // Lê a opção escolhida pelo usuário
    int opcao = Convert.ToInt32(Console.ReadLine()); 

    // Executa a operação correspondente à opção escolhida  
    switch (opcao)
    {
        case 1: 
            // Adiciona um funcionário de tempo integral
            Console.WriteLine("Digite um nome de um funcionário de tempo integral");
            string nomeTI = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário:");
            int matriculaTI = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário mensal do funcionário:");
            double salarioTI = Convert.ToDouble(Console.ReadLine());

            //funcionarioTI vai receber todos os parâmetros
            Funcionario_Tempo_Integral funcionarioTI = new Funcionario_Tempo_Integral(nomeTI, matriculaTI, salarioTI); 
            Empresa.Adicionar_Funcionario(funcionarioTI); //vai adicionar 
            Console.WriteLine("Funcionário de tempo integral adicionado com sucesso!");
            break;
        
        case 2:
            // Adiciona um funcionário de meio período
            Console.WriteLine("Digite o nome do funcionário de meio período");
            string nomeMP = Console.ReadLine();
            Console.WriteLine("Digite o número de matrícula");
            int matriculaMP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o salário por hora do funcionário");
            double salarioPorHoraMP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o número de horas trabalhadas do funcionário (Arredonde os minutos)");
            int horasTrabalhadasMP = Convert.ToInt32(Console.ReadLine()); // 

            Funcionario_Meio_Periodo funcionarioMP = new Funcionario_Meio_Periodo(nomeMP, matriculaMP, salarioPorHoraMP,horasTrabalhadasMP);
            Empresa.Adicionar_Funcionario(funcionarioMP);
            Console.WriteLine("Funcionário de meio periodo adicionado com sucesso!");
            break;
        
        case 3:
            // Remove um funcionário com base na matrícula
            Console.WriteLine();
            Console.WriteLine("Digite o número da matrícula do funcionário que deseja remover");
            Empresa.Exibir_Funcionario();

            int matriculaRemover = Convert.ToInt32(Console.ReadLine()); //adicionando dentro desta variável o número da mátricula que o usuário deseja remover

            Empresa.Remover_Funcionario(matriculaRemover); //aqui colocamos a variável
            Console.WriteLine("Funcionário removido com sucesso");
            Console.WriteLine();
            break;
        
        case 4:
            // Exibe informações de todos os funcionários
            Console.WriteLine();
            Empresa.Exibir_Funcionario();
            break;
        
        case 5:
            // Adiciona um projeto a um funcionário específico
            Console.WriteLine();
            Console.WriteLine("Digite o número de mátricula do funcionário que deseja adicionar no projeto");
            Empresa.Exibir_Funcionario();

            int matriculaProjeto = Convert.ToInt32(Console.ReadLine());

             // Percorre a lista de funcionários para encontrar o funcionário com a matrícula recebida
            for (int i = 0; i < Empresa.Lista_Funcionarios.Count; i++){
                if (Empresa.Lista_Funcionarios[i].Matricula == matriculaProjeto){
                    Console.WriteLine("Digite o nome do projeto:");
                    string projetoADD = Console.ReadLine();

                    Empresa.Lista_Funcionarios[i].Adicionar_Projeto(projetoADD);
                    Console.WriteLine("Projeto adicionado com sucesso!");
                    break;
                }
                else{
                    Console.WriteLine("Funcionário não encontrado, repita o processo");
                    Console.WriteLine();
                }
            }
            break;

        case 9:
            Console.WriteLine();
            Console.WriteLine("Saindo do programa...");
            return;

        default:
            Console.WriteLine();
            Console.WriteLine("Opção inválida! Tente novamente.");
            Console.WriteLine();
            break;
    }
}