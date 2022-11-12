class Insumos
{
    public string? nome;
    public string? cpf;
    public string? nomeEmpresa;
    public string? ramoEmpresa;
    public string? produtoEmpresa; 
    public List <string> insumosEmpresa = new List<string>();
    public List <decimal> valorInsumos = new List<decimal>();
    public List <string> nomesImpostos = new List<string>();
    public List <decimal> valorImposto = new List<decimal>();
   
    public Insumos(
        string? nome,
        string? cpf,
        string? nomeEmpresa,
        string? ramoEmpresa,
        string? produtoEmpresa, 
        string? insumosEmpresa,
        string? valorInsumos,
        string? nomesImpostos,
        string? valorImposto
    ) 
    {
        this.nome = nome;
        this.cpf = cpf;
        this.nomeEmpresa = nomeEmpresa;
        this.ramoEmpresa = ramoEmpresa;
        this.produtoEmpresa = produtoEmpresa;
        if (insumosEmpresa != null && insumosEmpresa != "") {
            string[] insumosEmpresaSplit = insumosEmpresa.Split (",");
            foreach (string insumo in insumosEmpresaSplit)
            {
                this.insumosEmpresa.Add(insumo);
            }
        }
        if (valorInsumos != null && valorInsumos != "") {
            string[] ValorInsumosSplit = valorInsumos.Split (",");
            foreach (string valor in ValorInsumosSplit)
            {
                this.valorInsumos.Add(Convert.ToDecimal(valor));
            }
        }
        if (nomesImpostos != null && nomesImpostos != "") {
            string[] nomesImpostosSplit = nomesImpostos.Split (",");
            foreach (string nomeImposto in nomesImpostosSplit)
            {
                this.nomesImpostos.Add(nomeImposto);
            }
        } 
        if (valorImposto != null && valorImposto != "") {
            string[] valorImpostoSplit = valorImposto.Split (",");
            foreach (string valorImpost in valorImpostoSplit)
            {
                this.valorImposto.Add(Convert.ToDecimal(valorImpost));
            }
        }
    }
}