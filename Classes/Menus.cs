
class Menus
{
    public void RecebeValores()
    {
            string valorEntrada =" ";
            ValidaCPF validaCPF = new();


            Console.WriteLine($"Informe o CPF !!");

            valorEntrada = Console.ReadLine();

            validaCPF.ConverteVetores(valorEntrada);
            
    }
    
}
