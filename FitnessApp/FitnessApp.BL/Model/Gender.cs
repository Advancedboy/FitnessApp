﻿using System;

namespace FitnessApp.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// название
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Создать новый пол 
        /// </summary>
        /// <param name="name">Имя пола. </param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым или  null", nameof(name));
            }

            Name = name;
            
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
