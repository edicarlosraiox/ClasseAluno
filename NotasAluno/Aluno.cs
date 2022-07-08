using System.Globalization;
namespace ExemploClasseAluno.NotasAluno
{
    public class Aluno
    {
        CultureInfo CI = CultureInfo.CurrentCulture;
        public string Nome;
        public double Nota1,Nota2,Nota3;
            
        

        public double NotaFinal( )
        {
          return Nota1 + Nota2 + Nota3;
        } 

       
        public bool Aprovado( )
        {
           if (NotaFinal() >= 60.0)
           {
              return true;
           }
              else{
                return false;
              
           }
        }
       
       
        public double notaRestante( )
        {
           if(Aprovado()){
               return 0.0;
           }
           else{
             return 60.0 - NotaFinal( );
           }
        }
        

        

        

         


   
    }
}