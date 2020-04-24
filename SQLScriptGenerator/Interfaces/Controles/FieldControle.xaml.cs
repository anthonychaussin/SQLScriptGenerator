using SQLScriptGenerator.Models;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows.Controls;

namespace SQLScriptGenerator.Interfaces.Controles
{
    /// <summary>
    /// Logique d'interaction pour FieldControle.xaml
    /// </summary>
    public partial class FieldControle : UserControl
    {
        public static ObservableCollection<SqlDbType> ListDbType
        {
            get
            {
                return new ObservableCollection<SqlDbType> { SqlDbType.BigInt, SqlDbType.Int, SqlDbType.SmallInt, SqlDbType.TinyInt, SqlDbType.NVarChar, SqlDbType.DateTime2 };
            }
        }

        public static ObservableCollection<DefaultValueFonction.Value> DefaultValue
        {
            get
            {
                return new ObservableCollection<DefaultValueFonction.Value> { DefaultValueFonction.Value.Null, DefaultValueFonction.Value.roguid, DefaultValueFonction.Value.DateTime2 };
            }
        }

        /// <summary>
        /// Controle de définition d'un champs
        /// </summary>
        public FieldControle()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}