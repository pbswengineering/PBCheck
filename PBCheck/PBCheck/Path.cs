using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PBCheck
{
    // Thanks to https://stackoverflow.com/a/52435685
    class Path
    {
        /// <summary>
        /// Gets the full path of the given executable filename as if the user had entered this
        /// executable in a shell. So, for example, the Windows PATH environment variable will
        /// be examined. If the filename can't be found by Windows, null is returned.</summary>
        /// <param name="exeName"></param>
        /// <returns>The full path if successful, or null otherwise.</returns>
        public static string GetFullPathFromWindows(string exeName)
        {
            if (exeName.Length >= MAX_PATH)
                throw new ArgumentException($"The executable name '{exeName}' must have less than {MAX_PATH} characters.",
                    nameof(exeName));

            StringBuilder sb = new StringBuilder(exeName, MAX_PATH);
            return PathFindOnPath(sb, null) ? sb.ToString() : null;
        }

        // https://docs.microsoft.com/en-us/windows/desktop/api/shlwapi/nf-shlwapi-pathfindonpathw
        // https://www.pinvoke.net/default.aspx/shlwapi.PathFindOnPath
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, SetLastError = false)]
        static extern bool PathFindOnPath([In, Out] StringBuilder pszFile, [In] string[] ppszOtherDirs);

        // from MAPIWIN.h :
        private const int MAX_PATH = 260;
    }
}
