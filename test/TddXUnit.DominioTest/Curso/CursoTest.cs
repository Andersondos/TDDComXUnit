using System;
using Xunit;


namespace TddXUnit.DominioTest.Curso
{
    public class CursoTest
    {
        [Fact]
        public void DeveCriarCurso()
        {
            var cursoEsperado = new 
            {
                Nome = "Informatica básica",
                CargaHoraria = 80,
                PublicoAlvo = PublicoAlvo.Estudante,
                Valor = 950
            };

            
            var curso = new Curso( cursoEsperado.Nome, cursoEsperado.CargaHoraria, cursoEsperado.PublicoAlvo, cursoEsperado.Valor);
            
            Assert.Equal(cursoEsperado.Nome, curso.Nome);
            Assert.Equal(cursoEsperado.CargaHoraria, curso.CargaHoraria);
            Assert.Equal(cursoEsperado.PublicoAlvo, curso.PublicoAlvo);
            Assert.Equal(cursoEsperado.Valor, curso.Valor);

            // cursoEsperado.ToExpectedObject().ShoulMatch(curso);

        }
    }

    public enum PublicoAlvo
    {
        Estudante,
        Universitario,
        Empregado,
        Empreededor
    }

    public class Curso
    {
        public Curso(string nome, double cargaHoraria, PublicoAlvo publicoAlvo, double valor)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;

        }

        public string Nome { get; private set; }
        public double CargaHoraria {get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double Valor {get; private set; }
    }
}