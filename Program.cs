using _NET_STUDY.Models;
using System.Globalization;

string[] linhas= File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}























// string dataString = "2022-04-17 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                       "yyyy-MM-dd HH:mm",
//                        CultureInfo.InvariantCulture,
//                        DateTimeStyles.None, 
//                        out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }


























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));


























// string numero1 ="10";
// string numero2 ="20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);



























// Pessoa p1 = new Pessoa(nome: "Alisson",sobrenome: "Dos Santos");

// Pessoa p2 = new Pessoa(nome: "Jorge",sobrenome: "Da Costa");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();































// Pessoa p1 = new Pessoa();

// p1.Nome = "Alisson";
// p1.Sobrenome = "Dos Santos";
// p1.Idade = 24;
// p1.Apresentar();