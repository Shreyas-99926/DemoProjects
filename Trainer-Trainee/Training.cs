using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    internal class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public Course Course { get; set; }

        public int GetNoOfTrainees()
        {
            //int traieeCount = 0;

            ////todo
            //traieeCount = Trainees.Count;

            //return traieeCount;
            return Trainees.Count;
        }

        public string GetTrainingOrgName()
        {
            return Trainer.TheOrganization.Name;
        }

        public int GetTrainingDurationInHrs()
        {
            int durationInHrs = 0;

            // todo
            // for each module
            foreach (Module module in Course.Modules)
            {
                // for each unit for a single module
                foreach (Unit unit in module.Units)
                {
                    durationInHrs += unit.Duration;
                }
            }

            return durationInHrs;
        }
    }
}
