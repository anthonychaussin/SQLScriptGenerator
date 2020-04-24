using System.Windows.Controls;

namespace SQLScriptGenerator.UserControle.TypeForm
{
    /// <summary>
    /// Logique d'interaction pour VueForm.xaml
    /// </summary>
    public partial class VueForm : UserControl
    {
        /// <summary>
        /// Formulaire permétant de définir les paramètres d'une vue
        /// </summary>
        public VueForm()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}