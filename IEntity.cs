namespace Entities
{
    public interface IEntity
    {
        int InstanceId { get; }
        T GetComponent<T>();
    }
}