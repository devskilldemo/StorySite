namespace StorySite.Data
{
    public interface IStorySiteUnitOfWork
    {
        IStoryRepository StoryRepository { get; }

        void Dispose();
        void Save();
    }
}