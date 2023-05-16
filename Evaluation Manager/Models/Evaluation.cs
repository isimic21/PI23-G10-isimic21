using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class Evaluation {
        public Activity Activity { get; set; }
        public Student Student { get; set; }
        public Teacher Evaluator { get; set; }
        public DateTime EvaluationDate { get; set; }
        public int Points { get; set; }
        public bool IsSufficentForGrade() {
            return Points >= Activity.MinPointsForGrade;
        }
        public bool IsSufficentForSignature() {
            return Points >= Activity.MinPointsForSignature;
        }
    }
}
