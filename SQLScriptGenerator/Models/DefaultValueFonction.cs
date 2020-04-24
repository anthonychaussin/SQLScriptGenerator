using System;
using System.Collections.Generic;

namespace SQLScriptGenerator.Models
{
    /// <summary>
    /// Valeurs par défaut possibles pour un champ
    /// </summary>
    public static class DefaultValueFonction
    {
        /// <summary>
        /// Enum des valeurs possibles
        /// </summary>
        public enum Value
        {
            /// <summary>
            /// Pas de contrainte
            /// </summary>
            Null,

            /// <summary>
            /// Date et heure système
            /// </summary>
            DateTime2,

            /// <summary>
            /// Identifiant séquentiel
            /// </summary>
            roguid
        }

        /// <summary>
        /// Valeur par défaut d'un champ
        /// </summary>
        private static readonly List<String> defaultValueFonctionList = new List<String> { "", "SYSDATETIME()", "NEWSEQUENTID" };

        /// <summary>
        /// Valeur par défaut d'un champ
        /// </summary>
        /// <param name="v">Enum <seealso cref="Value"/> sélectionné</param>
        /// <returns></returns>
        public static String GetDefaultValueFonctionList(Value v)
        {
            return defaultValueFonctionList[(int)v];
        }
    }
}