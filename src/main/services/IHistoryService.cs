namespace calc.src.main.services
{
    public interface IHistoryService 
    {
        void SaveRecord(string expression, string result);
        string GetHistory();
        void ClearHistory();
    }
}