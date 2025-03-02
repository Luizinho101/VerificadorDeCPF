
class ValidaCPF
{
   public void ConverteVetores(string valorEntrada)
   {
        char[] vetorChar = new char[11];
        int[] vetorInt = new int[vetorChar.Length];
        char[] caracteresEspeciais = new char[] {'!','@','#','$','%','¨','&','*','(',')','-','+','=','´','.',',','/','?','°','~','^','[',']',
        'a','b','c','d','e','f'};

        int resto1, resto2;

        //Converte string em vetor de char
        for(int i=0; i<11; i++)
        {
            vetorChar[i] = valorEntrada[i];
        }

        //Converte o char em um vetor de inteiros
        for (int i = 0; i < vetorChar.Length; i++)
        {
            vetorInt[i] = (int)char.GetNumericValue(vetorChar[i]);
        }
        resto1 = CalculaResto1(vetorInt);
        resto2 = CalculaResto2(vetorInt);
        ValidandoCPF(resto1,resto2,vetorInt);
   }

   public void LimpaCPF()
   {
        string[] caracteresEspeciais = new string[] {};
   }
   public int CalculaResto1(int[] a)
   {
        int numero =10;
        int valor1 =0;
        int resto1;

        for(int i=0; i<10; i++)
        {
            valor1 += a[i]*numero ;

            numero -=1;
        }

        return resto1 = (valor1 *10) % 11;
   }
   public int CalculaResto2(int[] a)
   {
        int valor2 =0;
        int resto2;

        int x =11;
        for(int i=0; i<11; i++)
        {
            valor2 += a[i]*x;

            x -=1;
        }
        return resto2 = (valor2 *10) % 11;
   }
   public void ValidandoCPF(int resto1, int resto2, int[] vetorInt)
   {
        if(resto1 ==11 || resto1 ==10)
        {
            resto1=0;
        }
        if(resto2 ==11 || resto2 ==10) 
        {
            resto2=0;
        }

        if(resto1 == vetorInt[9] && resto2 == vetorInt[10] || resto1 == 0 && resto2 ==0 || resto1 == vetorInt[9] && resto2 == 0  || resto2 == vetorInt[10] && resto2 == 0 )
        {
            Console.WriteLine("Seu CPF está correto !!");
        }
        else{
            Console.WriteLine("CPF não encontrado !!");
        }
   }
}
