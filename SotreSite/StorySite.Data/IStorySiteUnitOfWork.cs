namespace StorySite.Data
{
    public interface IStorySiteUnitOfWork
    {
        IStoryRepository StoryRepository { get; }
        ICommentRepository CommentRepository { get; }
        IUserRepository UserRepository { get; }
        IDeveloperRepository DeveloperRepository { get; }

        void Dispose();
        void Save();
    }
}