namespace TextSystem
{
    /// <summary>
    /// Represents a structural heading in the text.
    /// </summary>
    public sealed class Heading : TextElement
    {
        /// <summary>
        /// Gets the heading level from 1 (top) to 6 (nested).
        /// </summary>
        public int Level { get; }

        /// <summary>
        /// Gets the heading text.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Initializes a new heading with the given level and text.
        /// </summary>
        /// <param name="level">Heading level. Values below 1 become 1, above 6 become 6.</param>
        /// <param name="text">Heading text.</param>
        public Heading(int level, string text)
        {
            Level = Math.Clamp(level, 1, 6);
            ArgumentNullException.ThrowIfNull(text);
            Text = text;
        }

        /// <summary>
        /// Renders the heading in markdown style.
        /// </summary>
        /// <returns>Formatted heading string.</returns>
        public override string Render() => $"\n{new string('#', Level)} {Text}\n";

        /// <summary>
        /// Builds an indented table of contents entry based on the heading level.
        /// </summary>
        /// <returns>Indented TOC entry text.</returns>
        public override string GetTableOfContentsEntry()
        {
            string indent = new string(' ', (Level - 1) * 2);
            return $"{indent}- {Text}";
        }
    }
}
