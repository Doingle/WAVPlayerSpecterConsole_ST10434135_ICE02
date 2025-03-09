//No imports needed here, starting pont of the program

namespace WAV_Player_Specter_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a new instance of the MenuNavigation class
            MenuNavigation menuNavigation = new MenuNavigation();
            //Call the MenuStyle method from the MenuNavigation class
            menuNavigation.MenuStyle();

        }
    }
}

//---------------------------------------------------------------------------------------EOF-----------------------------------------------------------------------------------------------\\

//References:
//-Use of the Spectre.Console library: https://spectreconsole.net/
//-Use of the System.Media library: https://docs.microsoft.com/en-us/dotnet/api/system.media.soundplayer?view=net-6.0

//-For this project, I utilized AI21's Copilot to generate the code snippets.I then modified the code to fit the requirements and make it my own to the best of my abilities. I also submitted
// my code into AI21's Copilot chat window to assist in debugging errors with the code as well as to get instant feedback on the code I was writing, to ensure it met the requirements of the project.
// The structure of the code is my own but the various snippets have been inspired by the AI21's Copilot suggestions.

