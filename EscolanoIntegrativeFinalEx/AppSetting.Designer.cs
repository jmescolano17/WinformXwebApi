﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscolanoIntegrativeFinalEx {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
    internal sealed partial class AppSetting : global::System.Configuration.ApplicationSettingsBase {
        
        private static AppSetting defaultInstance = ((AppSetting)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new AppSetting())));
        
        public static AppSetting Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("NONE")]
        public string TOKEN {
            get {
                return ((string)(this["TOKEN"]));
            }
            set {
                this["TOKEN"] = value;
            }
        }
    }
}