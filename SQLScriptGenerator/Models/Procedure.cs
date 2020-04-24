using SQLScriptGenerator.Model;
using System;
using System.Collections.Generic;

namespace SQLScriptGenerator.Models
{
    /// <summary>
    /// Procédure SQL
    /// </summary>
    internal class Procedure
    {
        /// <summary>
        /// Nom de la procédure
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// List de paramètre
        /// </summary>
        public List<Parametre> ParamList { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="paramList"></param>
        public Procedure(String name, List<Parametre> paramList)
        {
            this.Name = name;
            this.ParamList = paramList;
        }
    }
}