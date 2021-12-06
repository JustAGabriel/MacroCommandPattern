namespace CommandPattern
{
    public interface ICommand
    {
        public void Execute();
        public void Revert();
    }
}