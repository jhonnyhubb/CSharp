namespace collections.Helper
{
    public class OperationsList
    {
        public void PrintListString(List<string> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine($"index: {i} and the value: {list[i]}");
            }
        }
    }
}