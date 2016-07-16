namespace CSharpConcepts
{
    public interface IRecording
    {
        double DurationOfSpeech { get; }
        void Speak();
    }
}