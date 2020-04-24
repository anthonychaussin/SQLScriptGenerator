using SQLScriptGenerator.Interfaces.Controles;
using System.Windows.Controls;

namespace SQLScriptGenerator.UserControle.TypeForm
{
    /// <summary>
    /// Logique d'interaction pour TableForm.xaml
    /// </summary>
    public partial class TableForm : UserControl
    {
        /// <summary>
        /// Formulaire permetant de définir les paramètres d'une table
        /// </summary>
        public TableForm()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(System.Object sender, System.Windows.RoutedEventArgs e)
        {
            this.FiledList.Children.Add(new FieldControle());
        }
    }
}