namespace ACM.BL
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

        public EntityStateOption entityState { get; set; }

        public bool Validate() { return true; }
    }
}

