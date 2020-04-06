using System;
using Curso_Intermediario_Udemy.Entities.Enums;

namespace Curso_Intermediario_Udemy.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + "," + Moment + "," + Status;
        }
    }
}
