using System.Windows.Controls;

namespace SQLScriptGenerator.Interfaces.Controles
{
    /// <summary>
    /// Logique d'interaction pour ParamControle.xaml
    /// </summary>
    public partial class ParamControle : UserControl
    {
        /// <summary>
        /// Controle pour la définition d'un paramètre
        /// </summary>
        public ParamControle()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}