namespace LibraryManagementSystem
{
    class main
    {
        public static void Main(string[] args)
        {
            LibraryClass Abhijeet = new LibraryClass();
            Console.WriteLine();
            Abhijeet.addbooks(6, "Mylife", "Abhijeet");
            Abhijeet.displaybooks();
            Console.WriteLine();
            Abhijeet.borrowbooks(6);
            Console.WriteLine();
            Abhijeet.borrowbooks(6);
            Console.WriteLine();
            Abhijeet.returnbooks(6,"mylife", "Abhijeet");
        }
    }
}
