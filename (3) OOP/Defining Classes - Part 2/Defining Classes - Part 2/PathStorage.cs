using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problems1to4
{
    public static class PathStorage
    {
        // static methods to save and load paths from a text file

        public static List<Path> LoadPaths(string pathFile)
        {
            var result = new List<Path>();

            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\Paths\" + pathFile + ".txt"))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Path thisPath = new Path(line);
                        result.Add(thisPath);
                        line = sr.ReadLine();
                    }
                }
            }
            catch(FileNotFoundException)
            {
                Console.Write("The path \"{0}\" cannot be found.", pathFile);
                return null;
            }
            return result;
        }

        public static void SavePaths(List<Path> paths, string pathsIdentifier)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\Paths\" + pathsIdentifier + ".txt"))
            {
                for (int i = 0; i < paths.Count; i++)
                {
                    sw.WriteLine(paths[i]);
                }
            }
        }
    }
}
