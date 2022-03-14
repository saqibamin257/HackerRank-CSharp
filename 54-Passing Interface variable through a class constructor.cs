using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class AlertService
    {
        private IAlertDAO _alert;

        //Constructor
        public AlertService(IAlertDAO alert)
        {
            _alert = alert;
        }

        public Guid RaiseAlert()
        {
            return _alert.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return _alert.GetAlert(id);
        }

        
    }
    public class AlertDAO:IAlertDAO
    {
        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return alerts[id];
        }
    }
    public interface IAlertDAO 
    {
        Guid AddAlert(DateTime time);
        DateTime GetAlert(Guid id);
    }
}
