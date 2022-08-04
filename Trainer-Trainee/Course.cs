using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    internal class Course
    {
        public List<Training> Trainings { get; set; } = new List<Training>();
        public List<Module> Modules { get; set; } = new List<Module>();

    }
}
