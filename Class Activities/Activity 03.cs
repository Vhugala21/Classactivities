using System;

public interface IDocumentOrganizer
{
    void OrganizeDocuments();
}

public interface IDocumentCompressor
{
    void CompressDocuments();
}

public interface IDocumentEncryptor
{
    void EncryptDocuments();
}

public class DocumentManagementSystem : IDocumentOrganizer, IDocumentCompressor, IDocumentEncryptor
{
    public void OrganizeDocuments()
    {
        Console.WriteLine("Organizing documents...");
    }
    public void CompressDocuments()
    {
        Console.WriteLine("Compressing documents...");
    }
    public void EncryptDocuments()
    {
        Console.WriteLine("Encrypting documents...");
    }
}
class Program
{
    static void Main(string[] args)
    {
       
        DocumentManagementSystem dms = new DocumentManagementSystem();
        
        IDocumentOrganizer organizer = dms;
        IDocumentCompressor compressor = dms;
        IDocumentEncryptor encryptor = dms;
       
        organizer.OrganizeDocuments();
        compressor.CompressDocuments();
        encryptor.EncryptDocuments();
    }
}