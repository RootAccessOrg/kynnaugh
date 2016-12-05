using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kynnaugh
{
    public class Plugin
    {
        // based on / a port of https://github.com/allquixotic/kynnaugh-cc/blob/master/kynnaugh.cpp
        const string PluginName = "kynnaugh";
        const string PluginVersion = "1.0";
        const int PluginApiVersion = 21;
        const string PluginAuthor = "RootAccessOrg";
        const string PluginDescription = "Speech recognition and text to speech for deaf users.";

        /*********************************** Required functions ************************************/
        /*
         * If any of these required functions is not implemented, TS3 will refuse to load the plugin
         */

        /// <summary>
        /// Unique name identifying this plugin
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_name()
        {
            return StringUtils.NativeUtf8FromString(PluginName);
        }

        /// <summary>
        /// Plugin version
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_version()
        {
            return StringUtils.NativeUtf8FromString(PluginVersion);
        }

        /// <summary>
        /// Plugin API version. Must be the same as the clients API major version, else the plugin fails to load.
        /// </summary>
        /// <returns></returns>
        [DllExport]
        int ts3plugin_apiVersion()
        {
            return PluginApiVersion;
        }

        /// <summary>
        /// Plugin author
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_author()
        {
            return StringUtils.NativeUtf8FromString(PluginAuthor);
        }

        /// <summary>
        /// Plugin description
        /// </summary>
        /// <returns></returns>
        [DllExport]
        IntPtr ts3plugin_description()
        {
            return StringUtils.NativeUtf8FromString(PluginDescription);
        }
    }
}
