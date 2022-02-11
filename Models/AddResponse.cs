namespace MediatoR.Models
{
    public class AddResponse
    {
        public virtual int Total { get; }

        public AddResponse(int total)
        {
            Total = total;
        }
    }

}