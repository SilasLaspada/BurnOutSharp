﻿namespace BurnOutSharp.ProtectionType
{
    public class ThreeTwoOneStudios : IContentCheck
    {
        /// <inheritdoc/>
        public string CheckContents(string file, byte[] fileContent, bool includePosition = false)
        {
            // 3 + (char)0x00 + 1 + 2 + (char)0x00 + 1 + (char)0x00 + S + (char)0x00 + t + (char)0x00 + u + (char)0x00 + d + (char)0x00 + i + (char)0x00 + o + (char)0x00 + s + (char)0x00 +   + (char)0x00 + A + (char)0x00 + c + (char)0x00 + t + (char)0x00 + i + (char)0x00 + v + (char)0x00 + a + (char)0x00 + t + (char)0x00 + i + (char)0x00 + o + (char)0x00 + n + (char)0x00
            byte[] check = new byte[] { 0x33, 0x00, 0x32, 0x00, 0x31, 0x00, 0x53, 0x00, 0x74, 0x00, 0x75, 0x00, 0x64, 0x00, 0x69, 0x00, 0x6F, 0x00, 0x73, 0x00, 0x20, 0x00, 0x41, 0x00, 0x63, 0x00, 0x74, 0x00, 0x69, 0x00, 0x76, 0x00, 0x61, 0x00, 0x74, 0x00, 0x69, 0x00, 0x6F, 0x00, 0x6E, 0x00 };
            if (fileContent.Contains(check, out int position))
                return "321Studios Online Activation" + (includePosition ? $" (Index {position})" : string.Empty);

            return null;
        }
    }
}
