using System;
using System.IO;

namespace FilesWriting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Writing of files and in different locations
            StreamWriter sr = File.CreateText("file.txt");
            sr.WriteLine("Some text to test out what happens");
            sr.WriteLine("Even more blablabla");
            sr.Write("Text without opening a new line -->");
            sr.Write("Help my hands are on fire");
            sr.Close();

            //moving or creating files in different spots
            sr = File.CreateText(@"C:\test\file.txt"); //make string into raw input by putting @ in front, else \t is seen as a tab
            sr.WriteLine("TEST TEST ON THE C DRIVE");
            sr.WriteLine("WOOP WOOP");
            sr.Close();

            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = Path.Combine(desktop, "file.txt"); // @ + "C:\Users\antho\OneDrive\Bureaublad" + "\file.txt"
            sr = File.CreateText(path);
            sr.WriteLine("Dries is sighing again, probably tired of this class or this annoying clown up front");
            sr.Close();

            if (File.Exists(path))
            {
                sr = File.AppendText(path);
                sr.WriteLine("Sorry Dries for putting you on the spot! no hate only love");
                sr.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                sr = File.AppendText(@"C:\test\file.txt");
                sr.WriteLine("HELLOOOOOOOO");
                sr.Close();
            }


            //deleting files, but BE CAREFUL!
            //if you want to test this at home, first execute the creation of the file, test the deleting afterwards
            string music = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            path = Path.Combine(music, "file.txt");
            sr = File.CreateText(path);
            sr.WriteLine("DING DONG MUSIC FILE"); //you don't HAVE to add content to it, file exists if you do .CreateText()
            sr.Close();

            if (File.Exists(path))
            {
                File.Delete(path);
            }



        }
    }
}