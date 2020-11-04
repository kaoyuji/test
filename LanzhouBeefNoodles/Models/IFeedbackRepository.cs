using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public interface IFeedbackRepository
    {
        public IEnumerable<Feedback> GetAllFeedbacks();
        public bool AddFeedback(Feedback feedback);
    }
}
