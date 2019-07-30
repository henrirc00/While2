using System;
using System.IO;
using System.Text;

namespace While2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                StreamReader é um leitor de arquivos, ele é uma classe em que voce determina o que ira representar
                o arquivo na camada da aplicaçao neste caso usamos a varivael arq que ira representar o arquivo que esta no disco
                C. Para fazer tal representção usamos a estrutura new StreamReader e o caminho do arquivo. No exemplo está o arquivo
                criado no disco C na pasta com o seu nome.
                Para acessar o arquivo foi necessario iniciar a string do caminho com um @ para evitar os erros com a barra invertida 
             */

            StreamReader arq = new StreamReader("C:\\Henrique\\arquivo.txt",Encoding.UTF7);

            string saida = "";

            while((saida=arq.ReadLine()) != null){
            Console.WriteLine(saida);  

            }

            
            arq.Close();
            

        
        }
    }
}
