using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program{
    static void Main(string[] args)
    {
        journalManager journalManager = new journalManager();
        journalManager.Run();
    }
}