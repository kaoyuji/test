using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.Models
{
    public class FeedbackRepository: IFeedbackRepository
    {
        private readonly AppDbContext _context;
        public FeedbackRepository(AppDbContext context)
        {
            _context = context;
        }
        public bool AddFeedback(Feedback feedback)
        {
            _context.Feedback.Add(feedback);
            return  _context.SaveChanges() > 0;
        }

        public IEnumerable<Feedback> GetAllFeedbacks()
        {
            return _context.Feedback;
        }
    }
}
