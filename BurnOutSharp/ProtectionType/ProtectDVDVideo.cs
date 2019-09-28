﻿using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BurnOutSharp.ProtectionType
{
    public class ProtectDVDVideo
    {
        public static string CheckPath(string path, IEnumerable<string> files, bool isDirectory)
        {
            if (!isDirectory)
                return null;

            if (Directory.Exists(Path.Combine(path, "VIDEO_TS")))
            {
                string[] ifofiles = files.Where(s => s.EndsWith(".ifo")).ToArray();
                for (int i = 0; i < ifofiles.Length; i++)
                {
                    FileInfo ifofile = new FileInfo(ifofiles[i]);
                    if (ifofile.Length == 0)
                        return "Protect DVD-Video";
                }
            }

            return null;
        }
    }
}
