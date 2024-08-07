﻿                           // Pythagoras Dokpesi BU/23C/IT/8941

// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file By Pythagoras Dokpesi.");
    }
}

// TODO: Get some information about the file
Console.WriteLine(File.GetCreationTime(filename));
Console.WriteLine(File.GetLastWriteTime(filename));
Console.WriteLine(File.GetLastAccessTime(filename));
File.SetAttributes(filename, FileAttributes.ReadOnly);
Console.WriteLine(File.GetAttributes(filename));



// TODO: We can also get general information using a FileInfo 

try{
    FileInfo fi = new(filename);
    Console.WriteLine($"{fi.Length}");
        Console.WriteLine($"{fi.IsReadOnly}");
            Console.WriteLine($"{fi.Directory}");


}
catch (Exception e) {
            Console.WriteLine($"Exception {e}");


}
// TODO: File information can also be manipulated

DateTime dt = new DateTime(2024,06,23 );
File.SetCreationTime(filename, dt);
            Console.WriteLine($" This file was created : {File.GetCreationTime(filename)}");
