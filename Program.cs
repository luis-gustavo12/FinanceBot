


using FinanceBot;
using System;
using System.Threading.Tasks;


class Program {


    static void Main(string[] args) {

        Console.WriteLine("*******************************************************");

        Console.WriteLine("SYNCHRONOUS");

        AssyncTasks.Print_One();
        AssyncTasks.Print_Two();


        Console.WriteLine("*******************************************************");
        Console.WriteLine("ASSYNCHRONOUS");

        Task task1 = Task.Run(() => AssyncTasks.Print_One());
        Task task2 = Task.Run(() => AssyncTasks.Print_Two());

        Task.WaitAll(task1, task2);


        Console.WriteLine("*******************************************************");



    }


    


}