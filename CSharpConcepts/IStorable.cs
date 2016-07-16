namespace CSharpConcepts
{
    public interface IStorable
    {
        void Read(string fileName);
        
        void Write(string fileName); 

    }
}