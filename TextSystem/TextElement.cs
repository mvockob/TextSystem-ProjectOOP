namespace TextSystem
{
    /// <summary>
    /// Abstract base for every structured text element.
    /// Defines the shared contract and hides rendering details from clients.
    /// </summary>
    public abstract class TextElement : ITextElement
    {
        /// <summary>
        /// Renders the element to its string representation.
        /// </summary>
        /// <returns>Formatted string content.</returns>
        public abstract string Render();

        /// <summary>
        /// Builds a table of contents entry for this element,
        /// or null when the element does not belong in the table.
        /// </summary>
        /// <returns>TOC entry text, or null when not applicable.</returns>
        public virtual string? GetTableOfContentsEntry()
        {
            return null;
        }
    }
}
