﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Research.Wwt.Sdk.Samples.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Research.Wwt.Sdk.Samples.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your system ({0}) is not authorized by the remote WWT client that you are trying to connect to.
        ///
        ///To resolve this issue, from the WWT client
        ///1. Open Remote Access Control Dialog (Settings-&gt;Remote Access Control)
        ///2. Add your IP address ({0}) to the Accept List.
        ///
        ///Once added to the accept list, try again..
        /// </summary>
        public static string ErrorLCAPIConnectionFailure {
            get {
                return ResourceManager.GetString("ErrorLCAPIConnectionFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred while performing the current operation. Please try again..
        /// </summary>
        public static string LCAPIErrorText {
            get {
                return ResourceManager.GetString("LCAPIErrorText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://www.worldwidetelescope.org/Docs/WorldWideTelescope_lcapi.html.
        /// </summary>
        public static string LCAPIFileUrl {
            get {
                return ResourceManager.GetString("LCAPIFileUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WorldWide Telescope (WWT) needs to be open to perform this operation. Please open WWT and try again..
        /// </summary>
        public static string WWTNotOpenErrorText {
            get {
                return ResourceManager.GetString("WWTNotOpenErrorText", resourceCulture);
            }
        }
    }
}