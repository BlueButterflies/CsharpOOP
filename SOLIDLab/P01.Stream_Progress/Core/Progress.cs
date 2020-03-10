using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class Progress
    {
        private readonly IProgress progress;

        // If we want to stream a music file, we can't
        public Progress(IProgress progress)
        {
            this.progress = progress;
        }

        public int CalculateCurrentPercent()
        {
            return (this.progress.Sent * 100) / this.progress.Length;
        }
    }
}
