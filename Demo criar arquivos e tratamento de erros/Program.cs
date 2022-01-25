using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();
nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite Enter para finalizar...");
ReadLine();

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Essa é a linha 1 do arquivo");
        sw.WriteLine("Oi eu sou o Goku");
        sw.WriteLine("Essa é a linha 3 do arquivo");
    }
    catch
    {
        WriteLine("O nome do arquivo é inválido");
    }
}


static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '-');
    }

    return nome;
}



















