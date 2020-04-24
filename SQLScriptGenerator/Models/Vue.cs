using System;

namespace SQLScriptGenerator.Model
{
    /// <summary>
    /// Vue d'une table SQL
    /// </summary>
    public class Vue
    {
        /// <summary>
        /// Table que la vue doit lire
        /// </summary>
        public Table TableToRead { get; set; }

        /// <summary>
        /// Nom de la vue
        /// </summary>
        internal String GetName()
        {
            return this.TableToRead.Name.Replace('T', 'V');
        }

        /// <summary>
        /// Contructeur
        /// </summary>
        /// <param name="tableToRead"></param>
        public Vue(Table tableToRead)
        {
            this.TableToRead = tableToRead;
        }
    }
}