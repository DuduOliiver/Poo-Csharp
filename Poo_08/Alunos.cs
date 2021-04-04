using System;
using System.Globalization;

namespace poo_08
{
    public class Alunos
    {
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFinal(){
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado (){
            if( NotaFinal() >= 6.0){
                return true;
            }
            else{
                return false;
            }
        }

        public double NotaRestante(){
            if(Aprovado()){
                return 0.0;
            }else{
                return 6.0 - NotaFinal();
            }
        }
    }
}
