﻿#pragma checksum "C:\Users\yang\Dropbox\Senior Project\Ceremedullum\Ceremedullum.Exe\Ceremedullum.Exe\Views\MainPageContentFrame\SearchPatient.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E79ED62F48C92AA4BCB1E11E95F9DF29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ceremedullum.Exe.Views.MainPageContentFrame
{
    partial class SearchPatient : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPageContentFrame\SearchPatient.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.SearchPatientData_Btn;
                }
                break;
            case 3: // Views\MainPageContentFrame\SearchPatient.xaml line 13
                {
                    this.PatientIdInput = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Views\MainPageContentFrame\SearchPatient.xaml line 14
                {
                    this.PatientSearchTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

