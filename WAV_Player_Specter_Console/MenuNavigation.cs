using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Spectre.Console;
//Used only necassary imports, improves performance and readability of code

namespace WAV_Player_Specter_Console
{
    class MenuNavigation
    {
        //List of songs to be played (Enables the feature to mark songs as played)
        private List<string> songs = new List<string>
        {
            "Camelphat & Elderbrook - Cola",
            "Darci - Throwback",
            "Playboi Carti - Timeless ft. The Weeknd",
            "Exit"
        };

        //HashSet to store the songs that have been played
        private HashSet<string> playedSongs = new HashSet<string>();

        //........................................................................................................................................................
        //Method to display the main menu for the functionality of the program and play the songs contained in the WAVS folder
        public void MenuStyle()
        {
            //Create a new instance of the ProgramMethods class
            ProgramMethods programMethods = new ProgramMethods();

            //Loop to keep the program running until the user decides to exit
            while (true)
            {
                // Create a heading for the menu utilizing spectre.console
                var headingText = Emoji.Known.MusicalNote + " WAV Player " + Emoji.Known.MusicalNote;
                var heading = new Rule($"[bold aqua]{headingText}[/]").Centered();
                // Display the application header
                AnsiConsole.Write(heading);

                // Create a list of song choices
                var songChoices = new List<string>();

                // This loop will check if the song has been played and add a "(Played)" to the song if it has been played
                foreach (var song in songs)
                {
                    // If the song has been played, add a "(Played)" to the song
                    if (playedSongs.Contains(song))
                    {
                        songChoices.Add($"[green]{song} (Played)[/]");
                    }
                    // If the song has not been played, add the song to the list
                    else
                    {
                        songChoices.Add(song);
                    }
                }

                // Prompt the user to select a song to play. This list is a feature from the Spectre.Console library, and allows scrolling through the list of songs and selecting the desired choice
                var songChoice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Please select a [aqua]song[/] [white]to play:[/]")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more songs)[/]")
                        .AddChoices(songChoices)
                );

                // Remove the color tags from the song choice
                string choice = songChoice.Replace("[green]", "").Replace("[/]", "").Replace(" (Played)", "");

                // If the user selects "Exit", the program will close
                if (choice == "Exit")
                {
                    AnsiConsole.MarkupLine("[red]WAV Player Closed[/]");
                    return;
                }

                // Display the song that is being played
                AnsiConsole.MarkupLine($"Playing {choice}");
                //NB - The song is added to the playedSongs list to mark it as played
                playedSongs.Add(choice);

                // Switch statement to play the selected song
                switch (choice)
                {
                    case "Camelphat & Elderbrook - Cola":
                        // Task.Run is used to run the method in a separate thread to prevent the progress bar from blocking the main thread...
                        Task.Run(() => programMethods.PlayWav1());
                        // Call the ProgressBarForWAV1 method to display the progress bar for the song
                        programMethods.ProgressBarForWAV1();
                        break;
                    case "Darci - Throwback":
                        Task.Run(() => programMethods.PlayWav2());
                        programMethods.ProgressBarForWAV2();
                        break;
                    case "Playboi Carti - Timeless ft. The Weeknd":
                        Task.Run(() => programMethods.PlayWav3());
                        programMethods.ProgressBarForWAV3();
                        break;
                    // If the user selects an invalid song, an error message is displayed
                    default:
                        Console.WriteLine("Invalid song choice");
                        break;
                }
            }
        }
    }
}
//---------------------------------------------------------------------------------------EOF-----------------------------------------------------------------------------------------------\\
