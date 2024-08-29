using _NET_STUDY.Models;

Pessoa p1 = new Pessoa(nome: "Alisson",sobrenome: "Dos Santos");

Pessoa p2 = new Pessoa("Jorge","Da Costa");

Curso cursoDeIngles = new Curso();

cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();































// Pessoa p1 = new Pessoa();

// p1.Nome = "Alisson";
// p1.Sobrenome = "Dos Santos";
// p1.Idade = 24;
// p1.Apresentar();