using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate,
               FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }
            F.Close();
           
            string writeText = "Hello World!";  // Create a text string
            File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the content
            Console.ReadLine();
            string myfile = @"filename.txt";

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(myfile))
            {
                sw.WriteLine("Gfg");
                sw.WriteLine("GFG");
                sw.WriteLine("GeeksforGeeks");
            }
           string  fName= @"filename.txt";
            string fName1 = @"filename1.txt";
            string sourceDir = @"C:\Users\91944\source\repos\FilesSample\bin\Debug";
            string backupDir = @"C:\Users\91944\source\repos\FilesSample\bin\Debug\1";
            try
            {
                // Will not overwrite if the destination file already exists.
              if( !File.Exists(fName1))
                    { 
                File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName1));
                }

                File.Delete(fName);
            }
             
            // Catch exception if the file was already copied.
            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }
        }
        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        {
            File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);
        }
    }
}