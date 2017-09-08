using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Aluno
    {
        //atributos
        private string nome;
        private string curso;
        private double nota1;
        private double nota2;
        private double media;
        //metodos especiais
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getCurso()
        {
            return this.curso;
        }
        public void setCurso(string curso)
        {
            this.curso = curso;
        }
        public double getNota1()
        {
            return this.nota1;
        }
        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }
        public double getNota2()
        {
            return this.nota2;
        }
        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }
        public double getMedia()
        {
            return this.media;
        }
        public void setMedia(double media)
        {
            this.media = media;
        }
        //metodos
        public string imprimir()
        {
            string texto = "O nome: " + this.getNome() + "O curso: " + this.getCurso() + "A media: " + this.getMedia();
            return texto;
        }
        public double calcularMedia()
        {
            media = (this.getNota1() + this.getNota2()) / 2;
            return this.media;
        }
        public bool aprovado()
        {
            if(this.getMedia() >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
