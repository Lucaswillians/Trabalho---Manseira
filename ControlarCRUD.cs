class ControlarCRUD
{
    public List<Insumos> dados = new List<Insumos>();
    public int position;

    public Insumos? buscaInsumo(string cpf) {
        bool achou = false;

        for (int contador = 0; contador < this.dados.Count; contador++) {
            Insumos insumo = this.dados[contador];

            if (insumo.cpf == cpf) {
                achou = true;
                this.position = contador;
                break;
            }
        }

        if (achou) {
            return this.dados[this.position];
        }
        else {
            return null;
        }
    }
}