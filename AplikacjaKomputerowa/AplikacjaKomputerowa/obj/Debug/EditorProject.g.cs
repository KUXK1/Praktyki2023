﻿#pragma checksum "..\..\EditorProject.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BB598CF363AB66968A9203FEAD4634D7FE99550A9308F9134F303D15386D32D1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using AplikacjaKomputerowa;
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


namespace AplikacjaKomputerowa {
    
    
    /// <summary>
    /// EditorProject
    /// </summary>
    public partial class EditorProject : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Option;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label NameL;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameB;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ChL1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChB1;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ChL2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChB2;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ChL3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\EditorProject.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ChB3;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AplikacjaKomputerowa;component/editorproject.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditorProject.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Option = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\EditorProject.xaml"
            this.Option.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Option_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\EditorProject.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameL = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.NameB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ChL1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ChB1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ChL2 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.ChB2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ChL3 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.ChB3 = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

