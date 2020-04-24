using System;
using System.Windows;

namespace SQLScriptGenerator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Champ input de l'utilisateur <seealso cref="Models.User.Name"/>
        /// </summary>
        public String UserName { get; set; }

        /// <summary>
        /// Champ input de l'utilisateur <seealso cref="Models.User.Firstname"/>
        /// </summary>
        public String UserFirstName { get; set; }

        private String sQLScriptGenerated;

        public String SQLScriptGenerated
        {
            get { return this.sQLScriptGenerated + " " + UserName + " " + UserFirstName; }
            set { sQLScriptGenerated = value; }
        }

        /// <summary>
        /// Principale formulaire de l'application
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}