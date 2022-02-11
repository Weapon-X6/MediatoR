using MediatR;

namespace MediatoR.Models
{
    public class AddRequest : IRequest<AddResponse>
    {
        public virtual int NumberOne { get; }
        public virtual int NumberTwo { get; }

        public AddRequest(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }
    }
}