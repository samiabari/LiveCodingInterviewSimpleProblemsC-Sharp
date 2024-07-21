namespace ManualLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<int> linkList = new LinkList<int>();
            linkList.Add(1);
            linkList.Add(2);
            linkList.Add(3);
            linkList.Add(4);
            linkList.Add(5);
            linkList.Traverse();
          
        }
    }
}
