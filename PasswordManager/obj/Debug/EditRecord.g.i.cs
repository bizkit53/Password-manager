#pragma checksum "..\..\EditRecord.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1FD41B69B77C858E6F53D06C384AADD83C7EE7EF9337FC00DB4AF895F27E073"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PasswordManager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PasswordManager
{


    /// <summary>
    /// EditRecord
    /// </summary>
    public partial class EditRecord : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PasswordManager;component/editrecord.xaml", System.UriKind.Relative);

#line 1 "..\..\EditRecord.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label label_serviceName;
        internal System.Windows.Controls.Label label_category;
        internal System.Windows.Controls.Label label_URL;
        internal System.Windows.Controls.Label label_login;
        internal System.Windows.Controls.Label label_password;
        internal System.Windows.Controls.TextBox textBox_serviceName;
        internal System.Windows.Controls.ComboBox comboBox_category;
        internal System.Windows.Controls.ComboBoxItem None;
        internal System.Windows.Controls.ComboBoxItem Business;
        internal System.Windows.Controls.ComboBoxItem Email;
        internal System.Windows.Controls.ComboBoxItem Finance;
        internal System.Windows.Controls.ComboBoxItem Games;
        internal System.Windows.Controls.ComboBoxItem Health;
        internal System.Windows.Controls.ComboBoxItem Productivity;
        internal System.Windows.Controls.ComboBoxItem Shopping;
        internal System.Windows.Controls.ComboBoxItem Social;
        internal System.Windows.Controls.TextBox textBox_URL;
        internal System.Windows.Controls.TextBox textBox_login;
        internal System.Windows.Controls.TextBox textBox_password;
        internal System.Windows.Controls.Button button_apply;
        internal System.Windows.Controls.Button button_cancel;
    }
}
