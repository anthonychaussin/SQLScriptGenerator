using System.Windows.Controls;

namespace SQLScriptGenerator.UserControle.TypeForm
{
    /// <summary>
    /// Logique d'interaction pour ProcForm.xaml
    /// </summary>
    public partial class ProcForm : UserControl
    {
        /// <summary>
        /// Formulaire permetant de définir les paramètres d'une procédure
        /// </summary>
        public ProcForm()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}