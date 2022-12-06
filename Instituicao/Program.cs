using Instituicao.Model;

Aluno aluno1 = new Aluno();
aluno1.Cpf = 101010101;
aluno1.Nome = "Vegas";
aluno1.Sobrenome = "Ribeiro";

Aluno aluno2 = new Aluno();
aluno2.Cpf = 1421548;
aluno2.Nome = "Lisa";
aluno2.Sobrenome = "Ferreira";

Aluno aluno3 = new Aluno();
aluno3.Cpf = 14545152;
aluno3.Nome = "Maria";
aluno3.Sobrenome = "Morais";



Matricula matriculados = new Matricula();
matriculados.Matriculados = new List<Aluno>();
matriculados.AlunosFormados = new List<Aluno>();

matriculados.AdicionarAlunos(aluno1);
matriculados.AdicionarAlunos(aluno2);
matriculados.AdicionarAlunos(aluno2);
matriculados.AdicionarFormados(aluno3);

matriculados.ListarAlunos();
matriculados.ListarFormados();


matriculados.PercentualEvasao();