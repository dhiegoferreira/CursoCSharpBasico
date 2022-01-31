using System;
using System.Collections.Generic;
using System.Linq;


namespace CursoCSharp.Section15.Services
{

    //Gemeric permitem que classes, interfaces e métodos posssam ser parametrizados por tipo.
    //Repare a estrutura logo após o nome da classe.
    class PrintService<T>
    {

        //Criando um vetor do tipo inteiro com o tamanho igual a 10.
        private T[] _values = new T[10];

        //contador para o [índice do vetor]
        private int _count = 0;

        
        //Podemos fazer uma programação defensiva para quando o contador (count) chegar no limíte das posições do vetor
        public void AddValue(T value)
        {
            if(_count == 10)
            {

                throw new InvalidOperationException("PrintService is full");
            }
            
            _values[_count] = value; //valor que chega pelo parâmetro
            _count++; //incrementando uma unidade ao count toda vez que ele receber o parâmetro value.
        }




        //Este método pegará a lista e retornará o primeiro elemento dela
        public T First()
        {
            //Programação defensiva para o caso em que a posição 0 do vetor estiver vazia.
            if (_values[0].ToString().Equals(""))
            {
                throw new InvalidOperationException("PrintService is null");
                
            }
            return _values[0]; //retorna o primeiro elemento do vetor
        }

        //
        public void Print()
        {
            Console.Write("[");
            for(int i = 0; i < _count; i++)
            {
                if (i == _count -1) //pois o i começa com zero
                {
                    Console.Write(_values[i]);
                }  else
                {
                    Console.Write(_values[i] + ",");
                }
            }
            Console.Write("]");
        }
    }
}

//Se colocar _values.Length o porgrama irá passar pelo for 10 vezes, e imprimirá o conteúdo de cada posição.
//Portanto, colocamos o _count , pois quando invocamos o método addValue o campo _count foi imcrementado de acordo com o value passado como parâmetro de entrada.
//Qual foi o problema?
//Deveríamos imprimir o conteúdo de cada posição do vetor desta forma 
// [10, 2 , 3] -- neste formato
// Logo deveríamos imprimir o colchete fora do laço e dentro do laço poderíamos ou fazer uma condicinal para quando o índice chega na penúltima poisção ou poderíamos fazer um for até a penúltima posição
//Desta forma:
/*
for (int i = 0; i < _count - 1; i++)
{
Console.WriteLine(_values[i] + ", ");

}
if(_count > 0) 
{
    Console.Write(_values[_count-1]);

}
Console.Write("]")




*/