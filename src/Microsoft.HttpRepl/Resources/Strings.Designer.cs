﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.HttpRepl.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.HttpRepl.Resources.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;set base {url}&apos; must be called before issuing requests to a relative path.
        /// </summary>
        internal static string Error_NoBasePath {
            get {
                return ResourceManager.GetString("Error_NoBasePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the base address to direct requests to..
        /// </summary>
        internal static string SetBaseCommand_Description {
            get {
                return ResourceManager.GetString("SetBaseCommand_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must specify a server.
        /// </summary>
        internal static string SetBaseCommand_MustSpecifyServerError {
            get {
                return ResourceManager.GetString("SetBaseCommand_MustSpecifyServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: set base [uri]
        ///
        ///Sets the base address to direct requests to..
        /// </summary>
        internal static string SetBaseCommand_Usage {
            get {
                return ResourceManager.GetString("SetBaseCommand_Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to set header {name} [value] - Sets or clears a header.
        /// </summary>
        internal static string SetHeaderCommand_Description {
            get {
                return ResourceManager.GetString("SetHeaderCommand_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: set header {name} [value]
        ///
        ///Sets or clears a header. When [value] is empty the header is cleared..
        /// </summary>
        internal static string SetHeaderCommand_Usage {
            get {
                return ResourceManager.GetString("SetHeaderCommand_Usage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sets the swagger document to use for information about the current server.
        /// </summary>
        internal static string SetSwaggerCommand_Description {
            get {
                return ResourceManager.GetString("SetSwaggerCommand_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must specify a swagger document.
        /// </summary>
        internal static string SetSwaggerCommand_SpecifySwaggerDocument {
            get {
                return ResourceManager.GetString("SetSwaggerCommand_SpecifySwaggerDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ui - Launches the Swagger UI page (if available) in the default browser.
        /// </summary>
        internal static string UICommand_Description {
            get {
                return ResourceManager.GetString("UICommand_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must be connected to a server to launch Swagger UI.
        /// </summary>
        internal static string UICommand_NotConnectedToServerError {
            get {
                return ResourceManager.GetString("UICommand_NotConnectedToServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to launch {0}.
        /// </summary>
        internal static string UICommand_UnableToLaunchUriError {
            get {
                return ResourceManager.GetString("UICommand_UnableToLaunchUriError", resourceCulture);
            }
        }
    }
}
