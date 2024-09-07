using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO_Explorando.Models
{
    public class ExemplosExceptions
    {
        public void Metodo1()
        {
            try{
            Metodo2();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message + " -> Exceção tratada.");
                //StackTrace é o rastro de comandos que mostra de onde saiu até onde foi (caminho)
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}