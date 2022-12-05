namespace Store_Boxes
{
    public class Program
    {
        static void Main(string[] args)
        {
            BoxList box = new BoxList();

            int result;
            string cmd1;
            do
            {
                
                box.EnterInfor();
                //box.AddInforToList();
                
                Console.WriteLine("If you want to end (enter 'end'), or no press any button");
                cmd1 = Console.ReadLine();

                result = String.Compare(cmd1, "end");
            } while (result != 0);
            box.DisplayInfor();
        }
    }
}