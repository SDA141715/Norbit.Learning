namespace OPPApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static class FileSystem
        {
            public static int GetSize(List<IFileSystemElement> items)
            {
                var totalSize = 0;

                foreach (var item in items)
                {
                    totalSize += item.GetSize();
                }

                return totalSize;
            }
        }

        class Drive : IFileSystemElement
        {
            public string Name { get; set; } 

        }

        class File : IFileSystemElement
        {
            public string Name { get; set; }
            public string path;
            List<IFileSystemElement> items;

            public int GetSize()
            {
                var totalSize = 0;

                foreach(var item in items)
                {
                    totalSize += item.GetSize();
                }

                return totalSize;
            }
        }

        class Directory
        { }

        public interface IFileSystemElement 
        {
            public string Name { get; set; }

            public int GetSize();
        }
    }
}
