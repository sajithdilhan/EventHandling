using System;

namespace EventHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IndexTask indexTask = new IndexTask();
            
            indexTask.Indexing += LogWriter;
            indexTask.IndexingFinished += IndexingCompleted;
            indexTask.IndexProducts();

        }

        public static void LogWriter(Object sender, string index)
        {
            Console.WriteLine(index);

        }

        public static void IndexingCompleted(object sender, string lastIndex)
        {
            Console.WriteLine("Indexing finished at: "+lastIndex);
        }
    }
}
