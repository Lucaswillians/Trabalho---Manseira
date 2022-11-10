class Insumos
{
    public string? nome;
    public string cpf;
    public string? nomeEmpresa;
    public string? ramoEmpresa;
    public string? produtoEmpresa; 
    public List <string> insumosEmpresa;
    public List <decimal> valorInsumos;
    public List <string> nomesImpostos;
    public List <decimal> valorImposto;
   
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
        string[] insumosEmpresaSplit = insumosEmpresa.Split (",");
        foreach (string insumo in insumosEmpresaSplit)
        {
            this.insumosEmpresa.Add(insumo);
        }
        string[] ValorInsumosSplit = valorInsumos.Split (",");
        foreach (string valor in ValorInsumosSplit)
        {
            this.valorInsumos.Add(Convert.ToDecimal(valor));
        }
        string[] nomesImpostosSplit = nomesImpostos.Split (",");
        foreach (string nomeImposto in nomesImpostosSplit)
        {
            this.insumosEmpresa.Add(nomeImposto);
        }
        string[] valorImpostoSplit = valorImposto.Split (",");
        foreach (string valorImpost in valorImpostoSplit)
        {
            this.valorImposto.Add(Convert.ToDecimal(valorImpost));
        }
    }
}