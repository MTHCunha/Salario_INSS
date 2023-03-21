using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Func
    {
        private int codigo;
        private string nome;
        private string RG;
        private double salario;

        public Func(int codigo, string nome, string rG, double salario, double inss, double líquido)
        {
            Codigo = codigo;
            Nome = nome;
            RG = rG;
            Salario = salario;
  
        }

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0) throw new Exception("O código deve ser > 0 !");
                else codigo = value;
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("Um nome deve ser cadastrado!");
                else
                    nome = value;
            }
        }
        public string Rg
        {
            get => RG;
            set
            {
                if (value.Trim().Length == 0)
                    throw new Exception("Insira o RG do funcionário");
                else
                    RG = value;
            }
        }
        public double Salario
        {
            get => salario;
            set
            {
                if (value <= 0)
                    throw new Exception("Não existem salários negativos");
                else
                    salario = value;
            }
        }
        public double INSS
        {
            get => salario * 0.11;
        } 

        public double CalculaSalario
        {
            get => salario - INSS;
        }

    }
}
