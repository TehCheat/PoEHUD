using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;
using System;

namespace PoeHUD.Poe
{
    public abstract class RemoteMemoryObject
    {
        public long Address { get; protected set; }
        protected TheGame Game { get; set; }
        protected Memory M { get; set; }

        protected Offsets Offsets => M.offsets;

        public T ReadObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
        {
            return ReadObject<T>(Address + offset);
        }


        public T ReadObject<T>(long addressPointer) where T : RemoteMemoryObject, new()
        {
            var t = new T { M = M, Address = M.ReadLong(addressPointer), Game = Game };
            return t;
        }

        public T GetObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
        {
            return GetObject<T>(Address + offset);
        }

        public T GetObjectAt<T>(long offset) where T : RemoteMemoryObject, new()
        {
            return GetObject<T>(Address + offset);
        }


        public T GetObject<T>(long address) where T : RemoteMemoryObject, new()
        {
            var t = new T { M = M, Address = address, Game = Game };
            return t;
        }

        public T AsObject<T>() where T : RemoteMemoryObject, new()
        {
            var t = new T { M = M, Address = Address, Game = Game };
            return t;
        }

        public override bool Equals(object obj)
        {
            var remoteMemoryObject = obj as RemoteMemoryObject;
            return remoteMemoryObject != null && remoteMemoryObject.Address == Address;
        }

        public static bool operator ==(RemoteMemoryObject lhs, RemoteMemoryObject rhs)
        {
            // Check for null on left side.
            if (Object.ReferenceEquals(lhs, null) || lhs.Address == 0)
            {
                if (Object.ReferenceEquals(rhs, null) || rhs.Address == 0)
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(RemoteMemoryObject lhs, RemoteMemoryObject rhs)
        {
            return !(lhs == rhs);
        }

        public override int GetHashCode()
        {
            return (int)Address + GetType().Name.GetHashCode();
        }
    }
}