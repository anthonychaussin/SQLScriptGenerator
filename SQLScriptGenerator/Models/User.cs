using System;

namespace SQLScriptGenerator.Models
{
    /// <summary>
    /// Définition d'un utilisateur
    /// </summary>
    public class User
    {
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Prénom de l'utilisateur
        /// </summary>
        public String Firstname { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="name">Nom de l'utilisateur</param>
        /// <param name="firstname">Prénom de l'utilisateur</param>
        public User(String name, String firstname)
        {
            this.Name = name;
            this.Firstname = firstname;
        }
    }
}