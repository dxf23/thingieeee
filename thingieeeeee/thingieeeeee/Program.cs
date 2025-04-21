using System;
using System.Net;

class Program
{
    static void Main()
    {
        mainmenu();
    }

    static void mainmenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the card values tool!");
            Console.WriteLine("Below are your list of options:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Download the file");
            Console.WriteLine("2. See the card values printed on the screen");
            Console.WriteLine("3. Exit the application");
            Console.WriteLine("-------------------------------");
            Console.Write("Please enter your choice (1, 2 or 3): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    downloadfile();
                    break;
                case "2":
                    print();
                    break;
                case "3":
                    exitapp();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
    static void exitapp()
    {
        Console.Clear();
        Console.Write("Are you sure you want to quit the application? (yes/no): ");
        string confirm = Console.ReadLine()?.Trim().ToLower();

        if (confirm == "yes")
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Exit cancelled. Returning to main menu...");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    static void downloadfile()
    {
        Console.Clear();
        Console.Write("Are you sure you want to download the file? (yes/no): ");
        string confirm = Console.ReadLine()?.Trim().ToLower();

        if (confirm == "yes")
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string address = "https://mega.nz/file/vHQBWQbA";
                    string fileName = "card-values.txt";

                    client.DownloadFile(address, fileName);
                    Console.WriteLine("File downloaded successfully to downloads.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Download failed: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Download cancelled. Returning to main menu...");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void print()
    {
        Console.Clear();
        Console.Write("Are you sure you want to print the card values? (yes/no): ");
        string confirm = Console.ReadLine()?.Trim().ToLower();

        if (confirm == "yes")
        {
            Console.WriteLine("\n--- Card Values ---\n");
            Console.WriteLine(@"<!DOCTYPE html>
<html xmlns=""http://www.w3.org/1999/xhtml"">
<head>
<meta property=""og:title"" content=""75 byte file on MEGA"" />
<meta property=""og:url"" content=""https://mega.nz/file/vHQBWQbA"" />
<meta property=""og:image"" content=""https://mega.nz/rich-file.png"" />
<meta property=""twitter:card"" content=""summary"" />
<meta property=""twitter:title"" content=""75 byte file on MEGA"" />
<meta property=""twitter:url"" content=""https://mega.nz/file/vHQBWQbA"" />
<meta property=""twitter:image"" content=""https://mega.nz/rich-file.png"" />

<meta http-equiv=""X-UA-Compatible"" content=""IE=Edge"" />
<meta http-equiv=""Content-Type"" content=""text/html, charset=UTF-8"" />
<meta name=""referrer"" content=""strict-origin-when-cross-origin"" />
<meta name=""google"" value=""notranslate"" />
<link rel=""icon"" href=""/favicon.ico?v=3"" type=""image/x-icon"" />
<link rel=""chrome-webstore-item"" href=""https://chrome.google.com/webstore/detail/bigefpfhnfcobdlfbedofhhaibnlghod"" />
</head>
<body id=""bodyel"" class=""theme-light not-logged"">
<script type=""text/javascript"" src=""/secureboot.js?r=1745064133"" charset=""utf-8""></script>
<div id=""overlay"" style=""display:none; width:100%; height:100%; position:absolute; left:0px; right:0px; cursor:wait; z-index:999999;""></div>
<div class=""download-overlay"" id=""download_overlay"" style=""display:none;""></div>
<div class=""nav-overlay hidden""></div>
<div id=""pageholder"" style=""display:none;""></div>
<div id=""mainlayout"" class=""main-layout no-tablet-layout"">
<div id=""startholder"" class=""fmholder""></div>
<div id=""fmholder"" class=""fmholder"" style=""display:none;""></div>
</div>
<a href="""" download=""filename"" id=""dllink"" style=""display:none;""></a>
<div style=""position:absolute;"" id=""startswfdiv""></div>
<div id=""tooltip""></div>
<div style=""position:absolute; left:0px; width:100%; top:0px; height:60px; z-index:99; display:none;"" id=""topmenufm"">
</div>
<textarea id=""chromeclipboard"" title=""copy"" style=""position:absolute;top:-100%;left:-100%;opacity:0"" readonly></textarea>
<iframe id=""i-ping"" style=""position:absolute;top:-100%;left:-100%;opacity:0;display:none"" src=""about:blank""></iframe>
</body>
</html>");
        }
        else
        {
            Console.WriteLine("Operation cancelled. Returning to main menu...");
        }

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}
