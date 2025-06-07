namespace CadastroProduto{
    class Funcionario{
        public string Nome{get;set;}
        public int Horas {get; set;}
        public double ValorHoras{get;set;}

        public Funcionario(){}

        public Funcionario(string nome,int horas,double valorhoras){
            this.Nome = nome;
            this.Horas = horas;
            this.ValorHoras = valorhoras;
        }
        public virtual double pagamento(){
            return Horas * ValorHoras ;
        }

        public override string ToString(){
            return $"Nome: {Nome}\n  Horas: {Horas}\n Valor total:{pagamento()}";
        }
    }
}