using System;
using System.Collections.Generic;
using System.Text;

namespace RhombusOfStars
{
    public class RhombusOfStarsDrawer
    {
        public string Drawer(int sizeRhombus)
        {
            StringBuilder builder = new StringBuilder();

            this.DrawTopPart(builder, sizeRhombus);
            this.DrawLineOfStars(builder, sizeRhombus);
            this.DrawBottomPart(builder, sizeRhombus);

            return builder.ToString();
        }

        private void DrawTopPart(StringBuilder builder, int n)
        {
            for (int i = 1; i <= n - 1; i++)
            {
                builder.Append(new string(' ', n - i));

                DrawLineOfStars(builder, i);
            }
        }

        private void DrawBottomPart(StringBuilder builder, int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                builder.Append(new string(' ', n - i));

                DrawLineOfStars(builder, i);
            }
        }

        private void DrawLineOfStars(StringBuilder builder, int n)
        {
            for (int star = 0; star < n; star++)
            {
                builder.Append('*');

                if (star < n - 1)
                {
                    builder.Append(' ');
                }
            }

            builder.AppendLine();
        }

    }
}
