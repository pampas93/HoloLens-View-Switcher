﻿#pragma checksum "C:\Users\asrikan\UnityProjects\ViewSwitcher\App\ViewSwitcher\FlatPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C008437C91E933F42118FB8AC96DC6E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViewSwitcher
{
    partial class FlatPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.InfoText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.Sunny = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\FlatPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Sunny).Click += this.WeatherBtn_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.Cloudy = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\FlatPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Cloudy).Click += this.WeatherBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.PartlyCloudy = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 45 "..\..\..\FlatPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PartlyCloudy).Click += this.WeatherBtn_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.PartlyCloudyIcon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.CloudyIcon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.SunnyIcon = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

