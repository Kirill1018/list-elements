// Updated by XamlIntelliSenseFileGenerator 01.06.2023 16:11:14
#pragma checksum "..\..\Addition.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3FC5AF92D8656AC651D2D99F6813936CA3F2EC72A20F5143A61CB15B2BFA09CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using list_elements;


namespace list_elements
{


    /// <summary>
    /// Addition
    /// </summary>
    public partial class Addition : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

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
            System.Uri resourceLocater = new System.Uri("/list elements;component/addition.xaml", System.UriKind.Relative);

#line 1 "..\..\Addition.xaml"
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
            switch (connectionId)
            {
                case 1:
                    this.name = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 2:
                    this.amount = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.meas_unit = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 4:
                    this.addendum = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\Addition.xaml"
                    this.addendum.Click += new System.Windows.RoutedEventHandler(this.addendum_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}
