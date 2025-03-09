using System;
using Spectre.Console;
using System.Media;
using System.Threading;
//Used only necassary imports, improves performance and readability of code


namespace WAV_Player_Specter_Console
{
    class ProgramMethods
    {
        // ------------------------------------------------------- Methods to play each song  ------------------------------------------------------- \\

        //...................................................................................................................
        //This method plays the first song in the WAVS folder
        public void PlayWav1()
        {
            //Path to the first song, locally on my PC, update this path to your own local path. The Songs are contained in the WAVS folder of this projects build folder.
            //("WAV_Player_Specter_Console\WAVS\Cola.wav")
            string WAV1Path = @"C:\Users\Dylan\Desktop\C#-DESKTOP PROJECTS\WAV_Player_Specter_Console\WAVS\Cola.wav";
            //Create a new SoundPlayer object and load the song
            SoundPlayer player = new SoundPlayer(WAV1Path);
            //loads the song
            player.Load();
            //Plays the song
            player.Play();

           
        }

        //...................................................................................................................
        //This method plays the second song in the WAVS folder
        public void PlayWav2()
        {
            string WAV2Path = @"C:\Users\Dylan\Desktop\C#-DESKTOP PROJECTS\WAV_Player_Specter_Console\WAVS\Throwback.wav";
            SoundPlayer player = new SoundPlayer(WAV2Path);
            player.Load();
            player.Play();

            
        }

        //...................................................................................................................
        //This method plays the third song in the WAVS folder
        public void PlayWav3()
        {
            string WAV3Path = @"C:\Users\Dylan\Desktop\C#-DESKTOP PROJECTS\WAV_Player_Specter_Console\WAVS\Timeless.wav";
            SoundPlayer player = new SoundPlayer(WAV3Path);
            player.Load();
            player.Play();

           
        }


        // --------------------------------------------------------- Progress bar Methods --------------------------------------------------------- \\


        //...................................................................................................................
        //This method creates a progress bar for the first song
        public void ProgressBarForWAV1()
        {

            //
            AnsiConsole.Progress()
                .Start(ctx =>
                {
                    var task = ctx.AddTask("[purple4_1]playback[/]");
                    while (!ctx.IsFinished)
                    {
                        //Sets duration. Progress bar does not dynamically update unfortunataly, but instead increments by a set fraction
                        task.Increment(0.0241f);
                        //Sets speed of progress bar
                        Thread.Sleep(100);
                    }
                });
            //Creates a new line
            Console.WriteLine();
        }

        //...................................................................................................................
        //This method creates a progress bar for the second song
        public void ProgressBarForWAV2()
        {


            AnsiConsole.Progress()
                .Start(ctx =>
                {
                    var task = ctx.AddTask("[purple4_1]playback[/]");
                    while (!ctx.IsFinished)
                    {
                        task.Increment(0.0658f);
                        Thread.Sleep(100);
                    }
                });
            Console.WriteLine();
        }

        //...................................................................................................................
        //This method creates a progress bar for the third song
        public void ProgressBarForWAV3()
        {


            AnsiConsole.Progress()
                .Start(ctx =>
                {
                    var task = ctx.AddTask("[purple4_1]playback[/]");
                    while (!ctx.IsFinished)
                    {
                        task.Increment(0.0556f);
                        Thread.Sleep(100);
                    }
                    Console.WriteLine();
                });
        }
    }
}
//---------------------------------------------------------------------------------------EOF-----------------------------------------------------------------------------------------------\\