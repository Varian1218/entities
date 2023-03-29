using UnityEngine;

namespace Entities
{
    public class GameObjectEntity : IEntity
    {
        private GameObject _impl;

        public GameObject Impl
        {
            set => _impl = value;
        }

        public int InstanceId => _impl.GetInstanceID();

        public T GetComponent<T>()
        {
            return _impl.GetComponent<T>();
        }
    }
}