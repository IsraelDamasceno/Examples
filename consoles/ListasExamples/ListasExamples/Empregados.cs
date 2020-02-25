using System;

namespace ListasExamples
{
    public class Empregados
    {
        public Empregados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public int Id { get; private set; }
        public String Nome { get; private set; }
        public Double Salario { get; private set; }

        public void SalarioAcrescentado(double porcentagem)
        {
            Salario += (Salario * porcentagem)+Salario;
        }

    }
}
