using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class DocumentSystem
{
    public static IList<IDocument> listOfDocuments;

    static void Main()
    {
        #if DEBUG
        Console.SetIn(new StreamReader(@"../../input.txt"));
        //Console.SetOut(new StreamWriter(@"../../output.txt"));
        #endif    
        listOfDocuments = new List<IDocument>();
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }

    private static void AddDocument(IDocument doc, string[] attributes)
    {
        IList<KeyValuePair<string, object>> attrList = new List<KeyValuePair<string, object>>();
        foreach (var attribute in attributes)
        {
            string[] keyValue = attribute.Split('=');
            attrList.Add(new KeyValuePair<string, object>(keyValue[0], keyValue[1]));
        }

        var name = (from pair in attrList
                    where pair.Key == "name"
                    select pair).FirstOrDefault();

        if (name.Value == null)
        {
            Console.WriteLine("Document has no name");
        }
        else
        {
            Console.WriteLine("Document added: {0}", name.Value);
            foreach (var item in attrList)
            {
                doc.LoadProperty(item.Key.ToString(), item.Value.ToString());
            }
            listOfDocuments.Add(doc);
        }
    }

    public static string GetName(string[] attributes)
    {
        string result = "";
        IList<KeyValuePair<string, object>> attrList = new List<KeyValuePair<string, object>>();
        foreach (var attribute in attributes)
        {
            string[] keyValue = attribute.Split('=');
            attrList.Add(new KeyValuePair<string, object>(keyValue[0], keyValue[1]));
        }

        var name = (from pair in attrList
                    where pair.Key == "name"
                    select pair).FirstOrDefault();

        if (name.Value == null)
        {
            return "";
        }
        return name.Value.ToString();
    }

    private static void AddTextDocument(string[] attributes)
    {
        AddDocument(new TextDocument(GetName(attributes)), attributes);
    }

    private static void AddPdfDocument(string[] attributes)
    {
        AddDocument(new PDFDocument(GetName(attributes)), attributes);
    }

    private static void AddWordDocument(string[] attributes)
    {
        AddDocument(new WordDocument(GetName(attributes)), attributes);
    }

    private static void AddExcelDocument(string[] attributes)
    {
        AddDocument(new ExcelDocument(GetName(attributes)), attributes);
    }

    private static void AddAudioDocument(string[] attributes)
    {
        AddDocument(new AudioDocument(GetName(attributes)), attributes);
    }

    private static void AddVideoDocument(string[] attributes)
    {
        AddDocument(new VideoDocument(GetName(attributes)), attributes);
    }

    /*
    * ListDocuments[] – prints on the console all the documents in the document system in their order of their addition. 
    * Each document should be printed alone on a single line in the following form:
    XXXDocument[key1=value1;key2=value2;…]
    The XXXDocument is the type of the document, e.g. PDFDocument, VideoDocument, etc. The keys should be ordered alphabetically.
    * Keys with no value should be skipped. In there are no documents, the command prints “No documents found”. Encrypted documents are shown differently, as follows:
    XXXDocument[encrypted]
    */
    private static void ListDocuments()
    {
        if (listOfDocuments.Count == 0)
        {
            Console.WriteLine("No documents found");
        }
        {
            foreach (var item in listOfDocuments)
            {
                Console.WriteLine(item);
            }
        }
    }

    /*  EncryptDocument[name] – changes the state of all documents matching the specified name to “encrypted”.
    * Documents that are already encrypted remain in “encrypted” state. For each document matching the specified name, 
    * the command prints as a result “Document encrypted: <name>” on the console or prints “Document does not support encryption: <name>”
    * if the document is not encryptable. In case of no document is matching the specified name, the message “Document not found: <name>”.
    */
    private static void EncryptDocument(string name)
    {
        int count = 0;
        foreach (var item in listOfDocuments)
        {
            if (item.Name == name)
            {
                count++;
                if (item is EncryptableBinaryDocument)
                {
                    (item as EncryptableBinaryDocument).Encrypt();
                    Console.WriteLine("Document encrypted: {0}", item.Name);
                }
                else
                {
                    Console.WriteLine("Document does not support encryption: {0}", item.Name);
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    /*
    * DecryptDocument[name] – works similarly like EncryptDocument, but changes the state of all matched documents to “not encrypted”
    * and prints as result one of the following messages: “Document decrypted: <name>”, “Document does not support decryption: <name>” 
    * or “Document not found: <name>”.
    */
    private static void DecryptDocument(string name)
    {
        int count = 0;
        foreach (var item in listOfDocuments)
        {
            if (item.Name == name)
            {
                count++;
                if (item is EncryptableBinaryDocument)
                {
                    (item as EncryptableBinaryDocument).Decrypt();
                    Console.WriteLine("Document decrypted: {0}", item.Name);
                }
                else
                {
                    Console.WriteLine("Document does not support decryption: {0}", item.Name);
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }

    /*
    * EncryptAllDocuments – changes the state of all documents that support encryption to “encrypted”.
    * As result, if at least one document supports encryption, prints on the console “All documents encrypted”, 
    * otherwise prints “No encryptable documents found”.
    */
    private static void EncryptAllDocuments()
    {
        int count = 0;
        foreach (var item in listOfDocuments)
        {
            if (item is EncryptableBinaryDocument)
            {
                count++;
                (item as EncryptableBinaryDocument).Encrypt();
            }
        }
        if (count != 0)
        {
            Console.WriteLine("All documents encrypted");
        }
        else
        {
            Console.WriteLine("No encryptable documents found");
        }
    }

    /*
    * ChangeContent[name;new_content] – changes the content of all editable documents matching the specified 
    * name with the specified new content. For each document matching the specified name, the command prints as a result 
    * “Document content changed: <name>” on the console or prints “Document is not editable: <name>” if the document is not 
    * editable. In case of no document is matching the specified name, the message “Document not found: <name>”.
    */
    private static void ChangeContent(string name, string content)
    {
        int count = 0;
        foreach (var item in listOfDocuments)
        {
            if (item.Name == name)
            {
                count++;
                if (item is IEditable)
                {
                    (item as IEditable).ChangeContent(content);
                    Console.WriteLine("Document content changed: {0}", item.Name);
                }
                else
                {
                    Console.WriteLine("Document is not editable: {0}", item.Name);
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("Document not found: {0}", name);
        }
    }
}