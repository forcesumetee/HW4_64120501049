using System;

class Program
{
    static void BuyBook(Stack<string> smartShelf, ref int transaction)
    {
        string book = Console.ReadLine();
        Queue<string> tmpShelf = new Queue<string>();
        while(smartShelf.GetLength() > 0)
        {
            string currentBook = smartShelf.Pop();
            transaction++;
            if(currentBook == book)
            {
                break;
            }
            else
            {
                tmpShelf.Push(currentBook);
            }
        }

        while(tmpShelf.GetLength() > 0)
        {
            smartShelf.Push(tmpShelf.Pop());
            transaction++;
        }
    }

    static void InputBook(Stack<string> smartShelf)
    {
        string book;
        while(true)
        {
            book = Console.ReadLine();
            if(book == "Stop")
            {
                break;
            }
            smartShelf.Push(book);
        }
    }

    static void Main(string[] args)
    {
        Stack<string> smartShelf = new Stack<string>();
        InputBook(smartShelf);

        int transaction = 0;
        while(smartShelf.GetLength() > 0)
        {
            BuyBook(smartShelf, ref transaction);
        }

        Console.WriteLine(transaction);
    }
}