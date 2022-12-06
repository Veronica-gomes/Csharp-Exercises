using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Instituicao.Model
{
    internal class Matricula
    {
        public List<Aluno> Matriculados { get; set; }
        public List<Aluno> AlunosFormados { get; set; }

        public void AdicionarAlunos(Aluno aluno)
        {
            Matriculados.Add(aluno);
        }

        public void AdicionarFormados(Aluno formado)
        {
            AlunosFormados.Add(formado);
        }

        public void ListarAlunos()
        {
            int matriculados = 0;
            foreach (Aluno aluno in Matriculados)
            {
                Console.WriteLine($"\n {matriculados} Nome: {aluno.Nome} {aluno.Sobrenome}");
                matriculados++;
            }
            Console.WriteLine($"O Total de matrículas são: {matriculados}");
        }

        public void ListarFormados()
        {
            int alunosFormados = 0;
            foreach (Aluno formado in AlunosFormados)
            {
                Console.WriteLine($"\n {alunosFormados} Nome: {formado.Nome} {formado.Sobrenome}");
                Console.WriteLine($"CPF: {formado.Cpf}");
                alunosFormados++;
            }
            Console.WriteLine($"O total de formados são: {alunosFormados}");
        }

        public void PercentualEvasao()
        {
            var matriculados = Matriculados.Count;
            var formados = AlunosFormados.Count;
            var total = formados + matriculados;

            var percEvasao = ((Double)formados / total);

            Console.WriteLine($"\n O total de evasão é de: {percEvasao * 100}%.");


            if (percEvasao < 0.10)
            {
                Console.WriteLine("Baixa evasão.");
            }

            if (percEvasao >= 0.10 && (percEvasao <= 0.15))
            {
                Console.WriteLine("Evasão média.");
            }

            if (percEvasao > 0.15 && (percEvasao <= 0.25))
            {
                Console.WriteLine("Evasão alta.");
            }

            if (percEvasao > 0.25)
                Console.WriteLine("Evasão muito alta.");

            else
                Console.WriteLine("Pressione qualquer tecla para encerrar.");
        }
    }
}
