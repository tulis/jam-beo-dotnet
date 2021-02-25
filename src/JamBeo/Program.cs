using System;
using System.Speech.Synthesis;

namespace JamBeo
{
    class Program
    {
        static void Main()
        {
            var now = DateTime.Now.ToString(format: "HH : mm tt");

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.
            synth.SelectVoiceByHints(VoiceGender.Female);
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.
            Console.WriteLine(now);
            synth.Speak(now);
        }
    }
}
