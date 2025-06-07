using CadastroProduto;
using System;
Funcionario funcionaio = new Funcionario();
List<Funcionario>funcionarios = new List<Funcionario>();
Console.WriteLine("digite quantos funcionario ira cadastra!");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n ; i++){
    Console.WriteLine("É funcionario terceirizado s/n");
    char esc = char.Parse(Console.ReadLine());
    Console.Write("digite o nome do funcionario: ");
    string nome = Console.ReadLine();
    Console.Write("digitre as horas trabalhada ");
    int horas = int.Parse(Console.ReadLine());
    Console.Write("digite o valor da hora:");
    double valorhoras = double.Parse(Console.ReadLine());
    if(esc == 's' || esc == 'S'){
        Console.Write("digite o adicional do terceirizado:");
        double adicional = double.Parse(Console.ReadLine());
        funcionarios.Add(new FuncionarioTerceiro(nome,horas,valorhoras,adicional));
    }else{
        funcionarios.Add(new Funcionario(nome,horas,valorhoras));
    }

    }

    foreach(Funcionario func in funcionarios){
            Console.WriteLine(func);
    }
