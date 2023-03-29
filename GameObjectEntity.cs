using UnityEngine;

namespace Entities
{
    public class GameObjectEntity : MonoBehaviour, IEntity
    {
        public int InstanceId => GetInstanceID();
    }
}
