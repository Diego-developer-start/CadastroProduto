namespace CadastroProduto{
    class FuncionarioTerceiro:Funcionario{
        public double Adicional{get; set;}

        public FuncionarioTerceiro(){}

        public FuncionarioTerceiro(string nome,int horas,double valorhoras, double adicional)
        :base(nome,horas,valorhoras)
        {
            this.Adicional = adicional;
        }
        public override double pagamento(){
            return base.pagamento() + Adicional* 1.1;
        }

        public override string ToString(){
            return $"Nome {Nome}\n Horas: {Horas}\n adicional terceirizado: {Adicional}\nvalor total {pagamento()}";
        }
    }
}