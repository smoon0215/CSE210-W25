using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class journalManager{
    private List<Book> books = new List<Book>();
    private Prompts prompts = new Prompts();

    public void WriteNewEntry(){
        string prompt = prompts.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        string entryText = Console.ReadLine();
        DateTime data = DateTime.Now;
        Book newEntry = new Book {date = data, Prompt = prompt, EntryText = entryText};
        books.Add(newEntry);
        Console.WriteLine("Entry added.\n");
    }

    public void DisplayJournal(){
        if (books.Count == 0){
            Console.WriteLine("Journal is empty.\n");
            return;
        }
        foreach (Book entry in books){
            Console.WriteLine(entry);
        }
    }

    public void SaveJournal(string filename){
        try 
        {
            string jsonString = JsonSerializer.Serialize(books, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(filename, jsonString);
            Console.WriteLine($"Journal saved to {filename}\n");
        }
        catch (Exception e){
            Console.WriteLine($"Error saving journal: {e.Message}\n"); 
        }
    }

    public void LoadJournal(string filename){
        try{
            if (File.Exists(filename)){
                string jsonString = File.ReadAllText(filename);
                books = JsonSerializer.Deserialize<List<Book>>(jsonString);
                Console.WriteLine($"JOurnal loaded from {filename}\n");
            }
            else{
                Console.WriteLine($"File not found: {filename}\n");
            }
        }
        catch (Exception e){
            Console.WriteLine($"Error loading journal: {e.Message}\n");
        }
    }

    public void Run(){
        while (true){
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load journal from file");
            Console.WriteLine("4. Save journal to file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice:");
            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int choiceNum)){
                switch (choiceNum){
                    case 1: 
                        WriteNewEntry();
                        break;
                    case 2:
                        DisplayJournal();
                        break;
                    case 3:
                        Console.WriteLine("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        LoadJournal(loadFilename);
                        break;
                    case 4:
                        Console.WriteLine("Enter filename to save: ");
                        string saveFilename = Console.ReadLine();
                        SaveJournal(saveFilename);
                        break;
                    case 5: 
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.\n");
                        break;
                }
            }
            else{
                Console.WriteLine("Invalid input. Please enter a number.\n");
            }
        }
    }
}