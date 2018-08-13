namespace MsgReader.Rtf
{
    /// <summary>
    /// Some utility functions
    /// </summary>
    internal static class Util
    {
        #region HasContentElement
        /// <summary>
        /// Checks if the root element has content elemens
        /// </summary>
        /// <param name="rootElement"></param>
        /// <returns>True when there are content elements</returns>
        public static bool HasContentElement(DomElement rootElement)
        {
            if (rootElement.Elements.Count == 0)
            {
                return false;
            }
            if (rootElement.Elements.Count == 1)
            {
                if (rootElement.Elements[0] is DomParagraph)
                {
                    var p = (DomParagraph) rootElement.Elements[0];
                    if (p.Elements.Count == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion
        
        #region Enum EmfToWmfBitsFlags
        private enum EmfToWmfBitsFlags
        {
            // ReSharper disable UnusedMember.Local
            // Use the default conversion
            EmfToWmfBitsFlagsDefault = 0x00000000,

            // Embedded the source of the EMF metafiel within the resulting WMF
            // metafile
            EmfToWmfBitsFlagsEmbedEmf = 0x00000001,

            // Place a 22-byte header in the resulting WMF file.  The header is
            // required for the metafile to be considered placeable.
            EmfToWmfBitsFlagsIncludePlaceable = 0x00000002,

            // Don't simulate clipping by using the XOR operator.
            EmfToWmfBitsFlagsNoXorClip = 0x00000004
            // ReSharper restore UnusedMember.Local
        };
        #endregion
    }
}