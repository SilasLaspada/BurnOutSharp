﻿using System.Collections.Generic;
using BurnOutSharp.Matching;

namespace BurnOutSharp.ProtectionType
{
    public class CDSHiELDSE : IContentCheck
    {
        /// <summary>
        /// Set of all ContentMatchSets for this protection
        /// </summary>
        private static readonly List<ContentMatchSet> contentMatchers = new List<ContentMatchSet>
        {
            // ~0017.tmp
            new ContentMatchSet(new byte?[] { 0x7E, 0x30, 0x30, 0x31, 0x37, 0x2E, 0x74, 0x6D, 0x70 }, "CDSHiELD SE"),
        };

        /// <inheritdoc/>
        public string CheckContents(string file, byte[] fileContent, bool includePosition = false)
        {
            return MatchUtil.GetFirstMatch(file, fileContent, contentMatchers, includePosition);
        }
    }
}
