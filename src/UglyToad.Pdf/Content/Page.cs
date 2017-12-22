﻿namespace UglyToad.Pdf.Content
{
    using System;
    using System.Collections.Generic;

    public class Page
    {
        /// <summary>
        /// The 1 indexed page number.
        /// </summary>
        public int Number { get; }

        public MediaBox MediaBox { get; }

        internal PageContent Content { get; }

        public IReadOnlyList<string> Text => Content?.Text ?? new string[0];

        internal Page(int number, MediaBox mediaBox, PageContent content)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Page number cannot be 0 or negative.");
            }

            Number = number;
            MediaBox = mediaBox;
            Content = content;
        }
    }
}