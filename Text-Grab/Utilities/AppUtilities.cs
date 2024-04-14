﻿using Windows.ApplicationModel;

namespace Text_Grab.Utilities;
internal class AppUtilities
{
    internal static bool IsPackaged()
    {
        try
        {
            // If we have a package ID then we are running in a packaged context
            PackageId dummy = Package.Current.Id;
            return true;
        }
        catch
        {
            return false;
        }
    }
}
