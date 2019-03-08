using System;


namespace ControlTrafico.Core.Dominio
{
    public class Event
    {
        public Guid idProcess { get; set; }
        public string process { get; set; }
        public string user { get; set; }
        public DateTime Time_Control { get; set; }
        public Event()
        {

        }
        public Event(Guid id)
        {
            if (!id.Equals(Guid.Empty))
            {
                this.idProcess = id;
            }
            else
            {
                this.idProcess = Guid.NewGuid();
            }

        }
    }
}
