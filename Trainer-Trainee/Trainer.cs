using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTraineeApp
{
    internal class Trainer
    {
        //private Organization org;
        //public string GetOrganizationName()
        //{
        //    return org.Name;
        //}
        public Organization TheOrganization { get; set; }
        //Trainee[] trainees = new Trainee[10];
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();
    }
}
