namespace day14LinkedLst
{
    class Program
    {
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            list.insertNode(70);
            list.insertNode(30);
            list.insertNode(56);
            list.printNodes();
        }
    }       

}
