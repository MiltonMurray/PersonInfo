namespace MiltonTrainingProject.Model
{
    public interface IPersonInterface<T>
    {
        int Add(T add);
        void Delete(int id);
        void Update(T update);
    }
}
