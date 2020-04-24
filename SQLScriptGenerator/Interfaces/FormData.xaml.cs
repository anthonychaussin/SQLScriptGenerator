using System.Windows.Controls;

namespace SQLScriptGenerator.UserControle
{
    /// <summary>
    /// Logique d'interaction pour FormData.xaml
    /// </summary>
    public partial class FormData : UserControl
    {
        /// <summary>
        /// Formulaire permetant de définir les paramètres du script
        /// </summary>
        public FormData()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}