public class ObjectPool<T> where T : new()
{
    private Stack<T> pool = new Stack<T>();

    public T Get()
    {
        return pool.Count > 0 ? pool.Pop() : new T();
    }

    public void Release(T obj)
    {
        pool.Push(obj);
    }
}