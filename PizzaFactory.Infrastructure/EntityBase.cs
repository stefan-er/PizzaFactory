using System;

namespace PizzaFactory.Infrastructure
{
    public abstract class EntityBase<IdType> : IEquatable<EntityBase<IdType>>
    {
        private readonly IdType id;

        public EntityBase(IdType id)
        {
            this.id = id;
        }

        public IdType Id
        {
            get
            {
                return id;
            }
        }

        public override bool Equals(object entity)
        {
            return entity != null && entity is EntityBase<IdType> && this == (EntityBase<IdType>)entity;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }

            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            if (entity1.Id.ToString() == entity2.Id.ToString())
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            return (!(entity1 == entity2));
        }

        public bool Equals(EntityBase<IdType> other)
        {
            if (other == null)
            {
                return false;
            }

            return this.Id.Equals(other.Id);
        }
    }
}
