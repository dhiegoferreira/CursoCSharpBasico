using System;


namespace CursoCSharp.Section3
{
    class Aula17
    {


        //Essa aula é sobre as convenções de declaração em C#




        //As convenções diz respeito a uma instrução de como deve-se declarar métodos, parâmetro, variáveis, namespaces, classes, properities e atributos de um programa c#


        //Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos) ex:

        //Pascal Case: LastName (namespaces, classes, properities e métodos)

        //Padrão _lastName(atributos "internos" da classe)



        public void NomeDoMetodo(String nomeDoParametro) { }

        //nesse exemplo utilizamos o PascalCase para o nome do método e o Camel Case: lastName para os parâmetros dentro dos métodos.

            //outro exemplo:

       //Temos a definição de uma propret ou propriedade do tipo string no qual definimo o nome em PascalCase.
        public string Titular { get; set; }


        //Definição de atributos internos à classe.
        private double _saldo;
        //atenção ao _




        //Definição do método em PascalCase
        public void Deposito(double quantia)
        {
            //Atributo interno definido acima
            _saldo += quantia;
        }

        public double GetSaldo()
        {
            return _saldo;

        }
    }
}
