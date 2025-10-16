using System;
using System.IO;
using System.Security.Cryptography;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("file.txt");
            stream.Write("This is a text file."); //writing text off into a file.
            stream.WriteLine("This is text first, then a new line"); //opening a new line after text
            stream.Write("Some more text");
            stream.Write("And even more.");
            stream.Close();

            //first create a folder on your c-drive to make this part work
            stream = File.CreateText(@"C:\test\file.txt"); //use / as a split between folders on MACOS
            stream.WriteLine("test file in different location");
            stream.Close();

            //create a file on your desktop and check contents
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //instead of desktop, can do anythign
            string path = Path.Combine(desktop, "file.txt");
            stream = File.CreateText(path);
            stream.Write("Hello dearest desktop <3");
            stream.Close();


            if (File.Exists(path))
            {
                stream = File.AppendText(path);
                stream.WriteLine("Testing more text.");
                stream.WriteLine("Even more!!!!!");
                stream.Close();
            }

            if (File.Exists(@"C:\test\file.txt"))
            {
                stream = File.AppendText(@"C:\test\file.txt");
                stream.WriteLine("HELLOOOOOOOOO");
                stream.Close();
            }

            //delete text file from a certain folder
            string music = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            string musicPath = Path.Combine(music, "file.txt");
            stream = File.CreateText(musicPath);
            stream.Close();

            //test previous lines of code before running code below, otherwise you have no idea if the file
            //is actually created

            if (File.Exists(musicPath))
            {
                File.Delete(musicPath);
            }

        }
    }
}