class Menu
{
    public string nome;
    public string empresa;
    public string ramo;

    public string produto;
    TelaInicial tela = new TelaInicial ();
    ControlarCRUD controlarCRUD = new ControlarCRUD();
    public string cpf;  
    
    public void MenuInicial ()
    {
        while (true) {
            this.tela.MontarTela (2,2,26,8);
            string resposta;
            Console.SetCursorPosition (4,3);
            Console.WriteLine ("Novo Cadastro:   (NC)");
            Console.SetCursorPosition (4,4);
            Console.WriteLine ("Situação:         (S)");
            Console.SetCursorPosition (4,5);
            Console.WriteLine ("Alterar algo:     (A) ");
            Console.SetCursorPosition (4,6);
            Console.WriteLine ("Deletar cadastro (DC)");
            Console.SetCursorPosition (4,7);
            Console.WriteLine ("Sair              (Q)");
            Console.SetCursorPosition (4,8);
            Console.WriteLine ("Opção: ");
            Console.SetCursorPosition (12,8);
            resposta = Console.ReadLine ();
            if (resposta.ToUpper () == "NC")
            {
                this.CadastroInicial ();
                this.Gastos ();
            }
            else if (resposta.ToUpper () == "S")
            {
                this.mostraBusca();
            }
            else if (resposta.ToUpper () == "A")
            {
                Insumos insumoProcura = this.abreBuscaPeloCPF();
                if (insumoProcura != null) {
                    // Após realizar a busca com sucesso, então o índice é definido no meio do processo.
                    int indice = this.controlarCRUD.position;
                    this.CadastroInicial ();
                    this.Gastos (indice);
                }
            }
            else if (resposta.ToUpper () == "DC")
            {
                // ainda nao fiz
            }
            else if (resposta.ToUpper() == "Q")
            {
                Console.Clear();
                break;
            }

        }
    }
    
    
    
    public void CadastroInicial ()
   
    {
        this.tela.MontarTela (2,2,62,12);
        string respNome, respEmpresa, respRamo, respProduto;
        Console.SetCursorPosition (4,3);
        Console.WriteLine ("Digite seu nome: ");
        Console.SetCursorPosition (22,3);
        this.nome = Console.ReadLine ();
        Console.SetCursorPosition (4,4);
        Console.WriteLine ("Digite seu CPF: ");
        Console.SetCursorPosition (22,4);
        this.cpf = Console.ReadLine ();
        Console.SetCursorPosition (4,5);
        Console.WriteLine ("Digite o nome de sua empresa ou negócio: ");
        Console.SetCursorPosition (45,5);
        this.empresa = Console.ReadLine ();
        Console.SetCursorPosition (4,6);
        Console.WriteLine ("Digite o ramo de sua empresa ou negócio: ");
        Console.SetCursorPosition (45,6);
        this.ramo = Console.ReadLine ();
        Console.SetCursorPosition (4,7);
        Console.WriteLine ("O que você produz? ou Qual sua prestação de serviços? ");
        Console.SetCursorPosition (4,8);
        this.produto = Console.ReadLine ();
    }   

    // Colocando um número absurdo apenas porque não consigo usar `null`.
    public void Gastos (int indice = 999999)
    {
        string respInsumos = "", respGastos = "", respImpostos = "", respNomeImpostos = "", respValorImpostos = "";
        this.tela.limparTela (2,2,62,12);
        this.tela.MontarTela (2,2,78,9);
        string resp = "";
        Console.SetCursorPosition (3,3);
        Console.WriteLine ("Digite os insumos que você utilizou para a realização do serviço: ");
        Console.SetCursorPosition (3,4);
        Console.WriteLine ("(Digite os insumos separando-os por virgula)");
        Console.SetCursorPosition (3,5);
        respInsumos = Console.ReadLine ();
        Console.SetCursorPosition (3,6);
        Console.WriteLine ("Quanto foi gasto com isso? ");
        Console.SetCursorPosition (3,7);
        respGastos = Console.ReadLine ();
        Console.SetCursorPosition (3,8);
        Console.WriteLine ("Houve imposto cobrado? (S/N)");
        Console.SetCursorPosition (32,8);
        resp = Console.ReadLine ();

        if (resp == null) {
            resp = "";
        }

        if (resp.ToUpper  () == "S" )
        {   
            this.tela.limparTela (2,2,78,9);
            this.tela.MontarTela (2,2,78,6);
            Console.SetCursorPosition (3,3);
            Console.WriteLine ("Quais foram os impostos?");
            Console.SetCursorPosition (28,3);
            respNomeImpostos = Console.ReadLine ();
            Console.SetCursorPosition (3,5);
            Console.WriteLine ("Quanto foi cobrado de imposto? ");
            Console.SetCursorPosition (34,5);
            respValorImpostos = Console.ReadLine ();
        }
        else {
            respNomeImpostos = "";
            respValorImpostos = "";
        }

        if (indice != 999999) {
            this.controlarCRUD.dados[indice] = new Insumos(
                this.nome, 
                this.cpf,
                this.empresa, 
                this.ramo, 
                this.produto, 
                respInsumos, 
                respValorImpostos, 
                respNomeImpostos, 
                respValorImpostos
            );
        }
        else {
            this.controlarCRUD.dados.Add(new Insumos(
                this.nome, 
                this.cpf,
                this.empresa, 
                this.ramo, 
                this.produto, 
                respInsumos, 
                respValorImpostos, 
                respNomeImpostos, 
                respValorImpostos
            ));
        }
    }

    public Insumos abreBuscaPeloCPF()
    {
        Console.SetCursorPosition (3,3);
        Console.WriteLine ("Procure pelo CPF: ");
        string? cpf = Console.ReadLine();

        Insumos  insumo = this.controlarCRUD.buscaInsumo(cpf);

        return insumo;
    }

    public void mostraBusca()
    {
        this.tela.limparTela (2,2,62,12);
        this.tela.MontarTela (2,2,78,9);

        Insumos insumo = this.abreBuscaPeloCPF();

        if (insumo != null) {
            this.tela.MontarTela (2,2,90,5);

            Console.SetCursorPosition(3, 3);
            Console.Write("CPF");
            Console.SetCursorPosition(10, 3);
            Console.Write("Nome");
            Console.SetCursorPosition(30, 3);
            Console.Write("Nome Empresa");
            Console.SetCursorPosition(50, 3);
            Console.Write("Ramo Empresa");
            Console.SetCursorPosition(70, 3);
            Console.Write("Insumos");
            Console.SetCursorPosition(90, 3);
            Console.Write("Impostos");
            Console.SetCursorPosition(110, 3);
            Console.Write("Valores Impostos");
            Console.SetCursorPosition(140, 3);
            Console.Write("Valores Insumos");

            Console.SetCursorPosition(3, 4);
            Console.Write(insumo.cpf);
            Console.SetCursorPosition(10, 4);
            Console.Write(insumo.nome);
            Console.SetCursorPosition(30, 4);
            Console.Write(insumo.nomeEmpresa);
            Console.SetCursorPosition(40, 4);
            Console.Write(insumo.ramoEmpresa);
            Console.SetCursorPosition(50, 4);
            Console.Write(string.Join(",", insumo.insumosEmpresa));
            Console.SetCursorPosition(60, 4);
            Console.Write(string.Join(",", insumo.nomesImpostos));
            Console.SetCursorPosition(70, 4);
            Console.Write(string.Join(",", insumo.valorImposto));
            Console.SetCursorPosition(80, 4);
            Console.Write(string.Join(",", insumo.valorInsumos));
        }
        else {
            Console.SetCursorPosition (3,6);
            Console.WriteLine("Não foi encontrado nenhum CPF correspondente!");
        }

        Console.ReadKey();
    }
}