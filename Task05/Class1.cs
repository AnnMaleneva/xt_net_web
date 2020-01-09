using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task05
{
    class Class1
    {
        public void FileWatcherMethod()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"G:\Task5Files";

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName;
            watcher.Filter = "*.txt";

            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            watcher.EnableRaisingEvents = true;

            static void OnChanged(object source, FileSystemEventArgs e) //пока убрала модификатор доступа, вернуть после создания класса
            {
               
            }

            static void OnRenamed(object source, RenamedEventArgs e) //пока убрала модификатор доступа, вернуть после создания класса
            {
                using (StreamWriter sw = File.AppendText(@"G:\\Task5Files\Logs\logInfo.txt"))
                {
                    sw.WriteLine("File: {0} renamed to {1}", e.OldName, e.Name);
                }
            }

            static void CopyFile()
            {

            }

            Console.ReadKey();
        }
    }
}
