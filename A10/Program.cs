using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace A10
{
    
    internal class Program
    {
        public static void createfile(string filename,string path)
        {
            string fpath = path + filename;
            if (File.Exists(fpath))
            {
                Console.WriteLine("The file already exists");
            }
            else
            {
                File.Create(fpath);
                Console.WriteLine("File created");
              
                
            }
        }
        public static void readfile(string fname,string path) {
            string fpath = path + fname;
            /*StreamReader sr = new StreamReader(fpath);
            string text = "";
            while ((text = sr.ReadLine()) != null)
            {
                Console.WriteLine(text);
            }
            sr.Close();*/
            if (File.Exists(fpath))
            {
                string[] lines = File.ReadAllLines(fpath);
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }
        public static void appendfile(string fname,string path)
        {
            string fpath = path + fname;
            if (File.Exists(fpath))
            {
                StreamWriter sw = File.AppendText(fpath);
                Console.WriteLine("Enter the text you want to append");
                string text=Console.ReadLine();
                sw.WriteLine(text);
                sw.Dispose();
                sw.Close();
                Console.WriteLine("Text is added");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
        public static void deletefile(string fname,string path){
            string fpath = path + fname;
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
        static void Main(string[] args)
        {
            string ch;
            do
            {
                
                int op;
                string fname,path;
                Console.WriteLine("Choose the operation you want to perform");
                Console.WriteLine("1.Create\n2.Read\n3.Append\n4.Delete");
                op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Enter the filename");
                        fname =Console.ReadLine();
                        Console.WriteLine("Enter the path where you want file to be created");
                        path=Console.ReadLine();
                        createfile(fname,path);
                        break;
                    case 2:
                        Console.WriteLine("Enter the filename");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter the path where you file exists");
                        path = Console.ReadLine();
                        readfile(fname, path);
                        break;
                    case 3:
                        Console.WriteLine("Enter the filename");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter the path of there file in which you want to add text");
                        path = Console.ReadLine();
                        appendfile(fname, path);
                        break;
                    case 4:
                        Console.WriteLine("Enter the filename");
                        fname = Console.ReadLine();
                        Console.WriteLine("Enter the path of the file you want to delete");
                        path = Console.ReadLine();
                        deletefile(fname, path);
                        break;


                }


                Console.WriteLine("If you want to perform more operations enter y ");
                ch=Console.ReadLine();
            } while (ch == "y");
        }
    }
}
