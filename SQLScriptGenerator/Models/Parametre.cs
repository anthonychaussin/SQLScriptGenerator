using System;
using System.Data;

namespace SQLScriptGenerator.Model
{
    /// <summary>
    /// Pramètre d'un procédure
    /// </summary>
    public class Parametre
    {
        /// <summary>
        /// Nom du Parametre
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
        /// Description du champ
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Contructeur par défaut
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="canBeNull">Le champ peut être null</param>
        /// <param name="description">Description du champ</param>
        public Parametre(String name, SqlDbType type, Boolean canBeNull, String description)
        {
            this.Name = name;
            this.Type = type;
            this.CanBeNull = canBeNull;
            this.Description = description;
        }

        /// <summary>
        /// Contructeur sans déscription
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="canBeNull">Le champ peut être null</param>
        public Parametre(String name, SqlDbType type, Boolean canBeNull) : this(name, type, canBeNull, String.Empty) { }

        /// <summary>
        /// Contructeur non null par défaut
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        public Parametre(String name, SqlDbType type) : this(name, type, false) { }

        /// <summary>
        /// Contructeur court. BIGINT non null
        /// </summary>
        /// <param name="name">Nom du champ</param>
        public Parametre(String name) : this(name, SqlDbType.BigInt) { }

        /// <summary>
        /// Contructeur commun non null type BIGINT
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="description">Description du champ</param>
        public Parametre(String name, String description) : this(name, SqlDbType.BigInt, false, description) { }

        /// <summary>
        /// Contructeur contrainte non null
        /// </summary>
        /// <param name="name">Nom du champ</param>
        /// <param name="type">Type de donnée sql</param>
        /// <param name="description">Description du champ</param>
        public Parametre(String name, SqlDbType type, String description) : this(name, type, false, description) { }
    }
}