using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class Music : IProgress
    {
        private string artist;
        private string album;

        public Music(string artist, string album, int length, int sent)
        {
            this.artist = artist;
            this.album = album;
            this.Length = length;
            this.Sent = sent;
        }

        public int Length { get; set; }

        public int Sent { get; set; }
    }
}
