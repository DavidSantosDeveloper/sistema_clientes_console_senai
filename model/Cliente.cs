namespace SistemaCliente.model{

    class Cliente{
        public string nome{get;set;}
        public string endereco{get;set;}
        public float valor{get; protected set;}
        public float valor_imposto{get; protected set;}
        public float total{get; protected set;}

        public virtual void Pagar_Imposto(float valor){
            this.valor=valor;
            this.valor_imposto=valor*0.1f;
            this.total=this.valor+this.valor_imposto;
        }
    }

}