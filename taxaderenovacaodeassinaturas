/* 
O recurso destina-se a melhorar a taxa de renovação das assinaturas do software.
Sua tarefa é exibir uma mesagem de renovação quando o usuário fazer o logon
Regra 1: o código deve exibir apenas  uma mensagem
Regra 2: se assinatura do cliente expirar em 10 dias ou menos, será exibida a mensagem Ÿour subscription will expire soon. Renew now!"
Regra 3: se expirar em 5 dias ou menos, será exibida: "Your subscription expires in 5 days. Renew now and save 10%."
Regra 4: se expirar em 1 dia, será exibida: "Your subscription expires within a day! Renew now and save 20%".
 Regra 5: se já tiver expirado, será exibido: "Your subscription has expired."
 Regra 6: se não expirar em dez dias ou menos, não será exibida nenhuma mensagem.
*/

using System;

public class SubscriptionChecker
{
    public static void Main()
    {
        
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
    
        if (daysUntilExpiration == 0)
        {
            Console.WriteLine ("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        
        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }
    }
}

