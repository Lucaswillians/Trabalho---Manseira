TelaInicial telaInicial = new TelaInicial ();
Menu menu = new Menu ();
string Awnser;

Console.WriteLine ("Gostaria de mudar as cores das letras e fundo? (S/N)");
Awnser = Console.ReadLine ();
if (Awnser.ToUpper () == "S")
{
  telaInicial.Estilo ();
}
Console.WriteLine ("Olá! Deseja as instruções básicas de como o sistema funciona? (S/N)");
Awnser = Console.ReadLine (); 
if (Awnser.ToUpper () == "S")
{
  telaInicial.Info ();
}
telaInicial.MontarTela (0,0,80,24);
menu.MenuInicial();


/*menu.CadastroInicial ();
menu.Gastos ();*/