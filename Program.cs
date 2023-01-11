namespace day14LinkedLst
{
    class Program
    {
        public static void Main(String[] args)
        {
            LinkedList list = new LinkedList();

            Console.WriteLine("Current Size of the list is: " + list.getListSize());

            list.insertNode(56);
          
            list.insertNode(70);
            list.printNodes();
            
            Console.WriteLine("Adding 25 at 2nd Location");
            list.insertNth(30, 1);
            list.printNodes(); 
             
        }
    }       

}
