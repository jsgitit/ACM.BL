using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public abstract class EntityBase
    {
        public bool HasChanges { get; set; }  // entity has changes needing to be saved
        public bool IsNew { get; private set; }  // determines if it is a new object
        public bool IsValid => Validate(); // calls the object's validate method when implemented.

        public abstract bool Validate();

        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public EntityStateOption EntityState { get; set; } // used to mark objects as Active or Deleted.

        

    }
}
