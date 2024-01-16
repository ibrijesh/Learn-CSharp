using System;

class  Program
{
    static void Main()
    {
       // not allowed string name = null;
       bool? areYouAdmin = null;

       if (areYouAdmin == true)
       {
           Console.WriteLine("User is Admin");
       }
       else if (areYouAdmin == false)
       {
           Console.WriteLine("User is not Admin");
       }
       else
       {
           Console.WriteLine("User did not answer the question");
       }
       
       
       
       // check struct value //
       
       int? ticketOnSale = 100;

       int availableTicket = ticketOnSale ?? 0;
       
       Console.WriteLine("Available Ticket = {0}",availableTicket);
       
    }
    
}