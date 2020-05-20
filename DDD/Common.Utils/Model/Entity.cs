using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Utils.Model
{
    public abstract class Entity
    {
        public virtual int Id { get; protected set; }
        /// <summary>
        /// Is Valid Allows error checking either by Fluent Validation or Custom rules
        /// </summary>
        public abstract bool IsValid
        {
            get;   
        }
        /// <summary>
        /// A dictionary describes property and error
        /// Errors can be computed by Fluent Validation or Custom Rules
        /// </summary>
        public abstract Dictionary<string,string> ValidationErrors { get; }
        /// <summary>
        /// Ef Requirment
        /// </summary>
        protected Entity()
        {

        }
        public Entity(int id)
        {
            Id = id;
        }
     }
}
