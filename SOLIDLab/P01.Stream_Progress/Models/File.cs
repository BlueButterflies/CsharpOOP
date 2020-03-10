namespace P01.Stream_Progress
{
    public class File : IProgress
    {
        private string name;

        public File(string name, int length, int sent)
        {
            this.name = name;
            this.Length = length;
            this.Sent = sent;
        }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
