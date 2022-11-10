class TelaInicial
{

    public void Estilo ()
    {
        string AwnserStyle;
        Console.Clear ();
        Console.WriteLine ("Cores disponíveis para a coloração das letras");
        Console.WriteLine ("Azul (A), Verde (V), Amarelo (AM), Vermelho (VM), Preto (P), Branco (B)");
        AwnserStyle = Console.ReadLine ();

        if (AwnserStyle.ToUpper() == "A")
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (AwnserStyle.ToUpper() == "V")
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (AwnserStyle.ToUpper() == "AM")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else if (AwnserStyle.ToUpper() == "VM")
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else if (AwnserStyle.ToUpper() == "P")
        {
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (AwnserStyle.ToUpper() == "B")
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine ("Cores disponíveis para a coloração do fundo");
        Console.WriteLine ("Azul (A), Verde (V), Amarelo (AM), Vermelho (VM), Preto (P), Branco (B)");
        AwnserStyle = Console.ReadLine ();

         if (AwnserStyle.ToUpper() == "A")
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        else if (AwnserStyle.ToUpper() == "V")
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        else if (AwnserStyle.ToUpper() == "AM")
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
        else if (AwnserStyle.ToUpper() == "VM")
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
        else if (AwnserStyle.ToUpper() == "P")
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else if (AwnserStyle.ToUpper() == "B")
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
    }

     public void Info ()
    {
        Console.Clear ();
        Console.WriteLine ("O Programa a seguir consiste no calculo dos porcentuais de lucros que uma empresa pode vir a ter.");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Perguntando o seguimento e os produtos utilizados para a produção de algo, com base no ramo da empresa.");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("O programa se constitui em saber seu nome, qual sua empresa e o qual seu ramo empresarial.");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Além de tudo, perguntará quais os insumos que você orçou para produzir seus produtos ou serviço");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Após isso, o programa pedirá para você informar o preço de cada insumo");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Caso o preço se alterou, será possível editar em outro momento. ");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Além de conseguir editar os insumos, será possível alterar algo que você queira mudar, como nome, ramo, ou até mesmo a empresa.");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("O programa se encerrrá com um calculo mostrando todos os seus gastos, e seus lucros, e com uma conclusão final se o ramo está dando certo ou não.");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Essas foram as intrução básicas, o que não foi explicado, será entendido de forma didática com o andamento do sistema...");
        Console.ReadKey ();
        Console.Clear();
        Console.WriteLine ("Aproveite!");
        Console.ReadKey ();
        Console.Clear();
    }


    public void MontarTela (int ci, int li, int cf, int lf)
    {
        int coluna, linha;

        this.limparTela (ci, li, cf, lf);

        for (coluna = ci; coluna <= cf; coluna++)
        {
            Console.SetCursorPosition(coluna, li);
            Console.Write("-");
        
            Console.SetCursorPosition(coluna, lf);
            Console.Write("-");
        }   

        for ( linha = li; linha <= lf; linha++)
        {
            Console.SetCursorPosition(ci, linha);
            Console.Write("|");

            Console.SetCursorPosition(cf, linha);
            Console.Write("|");
        }

        Console.SetCursorPosition (ci, li); Console.Write ("+");
        Console.SetCursorPosition (ci, lf); Console.Write ("+");
        Console.SetCursorPosition (cf, li); Console.Write ("+");
        Console.SetCursorPosition (cf, lf); Console.Write ("+");
    }

   public void limparTela (int ci, int li, int cf, int lf)
    {
        int x, y;
           for (x = ci; x <= cf; x ++)
        {
            for (y = li; y <= lf; y ++)
            { 
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            }
        }
    }



    
}