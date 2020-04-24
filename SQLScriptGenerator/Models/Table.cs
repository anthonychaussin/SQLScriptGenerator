using System;
using System.Collections.Generic;

namespace SQLScriptGenerator.Model
{
    /// <summary>
    /// Représentation d'une table SQL
    /// </summary>
    public class Table
    {
        /// <summary>
        /// Nom de la base de donnée
        /// </summary>
        public String Base { get; set; }

        /// <summary>
        /// Nom du shéma
        /// </summary>
        public String Shema { get; set; }

        /// <summary>
        /// Nom de la table
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// List des champs
        /// </summary>
        public List<Champ> FieldList { get; set; }

        /// <summary>
        /// Contructeur par défaut
        /// </summary>
        /// <param name="dbbase">Nom de la base de donnée</param>
        /// <param name="shema">Nom du shéma</param>
        /// <param name="name">Nom de la table</param>
        /// <param name="fieldList">List des champs</param>
        public Table(String dbbase, String shema, String name, List<Champ> fieldList)
        {
            this.Base = dbbase;
            this.Shema = shema;
            this.Name = name;
            this.FieldList = fieldList;
        }

        /// <summary>
        /// Ajoute une liste de champ à la table
        /// </summary>
        /// <param name="FieldList">Liste de <seealso cref="Champ"/></param>
        public void AddField(List<Champ> FieldList)
        {
            this.FieldList.AddRange(FieldList);
        }

        /// <summary>
        /// Ajoute un champ à la table
        /// </summary>
        /// <param name="c"><seealso cref="Champ"/> à la table</param>
        public void AddField(Champ c)
        {
            this.FieldList.Add(c);
        }
    }
}