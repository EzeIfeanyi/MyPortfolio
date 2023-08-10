namespace MVCProjectPractice
{
    public interface IMail
    {
        static abstract string Send(string Subject, string Body, string AttachmentPath);
    }
}