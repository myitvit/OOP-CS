﻿namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase
    {
        public bool HasChanges { get; set; }

        public bool IsNew { get; private set; }

        public bool IsValid
        {
            get { return Validate(); }
        }

        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();
    }
}

