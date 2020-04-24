using SQLScriptGenerator.Models;
using System;
using System.Data;

namespace SQLScriptGenerator.Model
{
    /// <summary>
    /// Définition d'un champ d'une table
    /// </summary>
    public class Champ
    {
        /// <summary>
        /// Nom du champ
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Type de donné
        /// </summary>
        public SqlDbType Type { get; set; }

        /// <summary>
        /// Le champ peut être null
        /// </summary>
        public Boolean CanBeNull { get; set; }

        /// <summary>
        /// Valeur par défaut du champ
        /// </summary>
        public DefaultValueFonction.Value DFContraint { get; set; }

        /// <summary>
        /// Description du champ
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Contructeur par défaut
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="canBeNull">Le champ peut être null</param>
        /// <param name="dFContraint">Contrainte par défault <seealso cref="DefaultValueFonction.Value"/></param>
        /// <param name="description">Description du champ</param>
        public Champ(String name, SqlDbType type, Boolean canBeNull, DefaultValueFonction.Value dFContraint, String description)
        {
            this.Name = name;
            this.Type = type;
            this.CanBeNull = canBeNull;
            this.DFContraint = dFContraint;
            this.Description = description;
        }

        /// <summary>
        /// Contructeur sans déscription
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="canBeNull">Le champ peut être null</param>
        /// <param name="dFContraint">Contrainte par défault <seealso cref="DefaultValueFonction.Value"/></param>
        public Champ(String name, SqlDbType type, Boolean canBeNull, DefaultValueFonction.Value dFContraint) : this(name, type, canBeNull, dFContraint, String.Empty) { }

        /// <summary>
        /// Contructeur sans contrainte
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="canBeNull">Le champ peut être null</param>
        /// <param name="description">Description du champ</param>
        public Champ(String name, SqlDbType type, Boolean canBeNull, String description) : this(name, type, canBeNull, DefaultValueFonction.Value.Null, description) { }

        /// <summary>
        /// Contructeur sans contrainte ni description
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="canBeNull">Le champ peut être null</param>
        public Champ(String name, SqlDbType type, Boolean canBeNull) : this(name, type, canBeNull, String.Empty) { }

        /// <summary>
        /// Contructeur non null par défaut
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        public Champ(String name, SqlDbType type) : this(name, type, false) { }

        /// <summary>
        /// Contructeur court. BIGINT non null
        /// </summary>
        /// <param name="name">Nom du champ</param>
        public Champ(String name) : this(name, SqlDbType.BigInt) { }

        /// <summary>
        /// Contructeur commun non null type BIGINT
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="description">Description du champ</param>
        public Champ(String name, String description) : this(name, SqlDbType.BigInt, false, description) { }

        /// <summary>
        /// Contructeur contrainte non null
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="dFContraint">Contrainte par défault <seealso cref="DefaultValueFonction.Value"/></param>
        /// <param name="description">Description du champ</param>
        public Champ(String name, SqlDbType type, DefaultValueFonction.Value dFContraint, String description) : this(name, type, false, dFContraint, description) { }
    }
}