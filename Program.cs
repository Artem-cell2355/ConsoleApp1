using System;
using System.Threading;
using System.Threading.Tasks;
//interface
interface IGenericInterface<T>
{
    T GenericMethod(T value);
}
interface INormalInterface
{
    void NormalMethod();
}
//MyAbstractClass
abstract class MyAbstractClass
{
    public abstract void AbstractMethod();

    public void RegularMethod()
    {
        Console.WriteLine("a regular abstract class method");
    }
}
//клас, що наслідує та імплементує
class MyClass : MyAbstractClass, IGenericInterface<int>, INormalInterface
{
    public override void AbstractMethod()
    {
        Console.WriteLine("Abstract method implementation");
    }
    public int GenericMethod(int value)
    {
        return value * 2;
    }
    public void NormalMethod()
    {
        Console.WriteLine("Implementing a regular interface method");
    }
}

//методи з тасками
class Program
{
    static async Task RunThreeTasks()
    {
        Random rnd = new Random();
        Task[] tasks = new Task[3];

        for (int i = 0; i < 3; i++)
        {
            int taskNum = i + 1;
            tasks[i] = Task.Run(async () =>
            {
                int delay = rnd.Next(1000, 3001);
                await Task.Delay(delay);
                Console.WriteLine($"Task {taskNum}");
            });
        }

        await Task.WhenAll(tasks);
    }
    static async Task RunThreeTasksReturnFirst()
    {
        Random rnd = new Random();
        Task<string>[] tasks = new Task<string>[3];

        for (int i = 0; i < 3; i++)
        {
            int taskNum = i + 1;
            tasks[i] = Task.Run(async () =>
            {
                int delay = rnd.Next(1000, 3001);
                await Task.Delay(delay);
                return $"Task {taskNum}";
            });
        }
        Task<string> firstFinished = await Task.WhenAny(tasks);
        Console.WriteLine(await firstFinished);
    }

    static async Task Main()
    {
        await RunThreeTasks();
        await RunThreeTasksReturnFirst();
    }
}
