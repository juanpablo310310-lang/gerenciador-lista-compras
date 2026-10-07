using System ;

public class Program
{
   public static void Main(string[] args) 
   {
       
        List <string> products = new List<string>();
        
        int option = 0;
        
         while(option != 4)
        {
                 
        
        Console.WriteLine("1 - Adicionar item");
        Console.WriteLine("2 -  Remover item");
        Console.WriteLine("3 - Exibir items");
        Console.WriteLine("4 - Sair");
        
        option = Convert.ToInt32(Console.ReadLine());
        
        switch (option)
        {
            case 1:
            Console.WriteLine("Adicione um item:");
            
            string  product = Console.ReadLine();
            
            products.Add(product);
            
            Console.WriteLine("Item adicionado");
            break;
            
             case 2:
             
             Console.WriteLine("Digite o item que deseja remover");
             
             string productToRemove = Console.ReadLine();
             bool removed = products.Remove(productToRemove);
             
             if(removed)
             {
                 Console.WriteLine("Item removido");
                 
             }    
             else
             {
                 Console.WriteLine("Item nao encontrado");
             }
             break;
             
             case 3:
             
             foreach(string item in products)
             {
                 Console.WriteLine(item);    
             }
             break;
          
           }
       
       }
   }


  
