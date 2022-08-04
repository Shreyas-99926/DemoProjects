using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    internal class Trainee
    {
        public Trainer Trainer { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
