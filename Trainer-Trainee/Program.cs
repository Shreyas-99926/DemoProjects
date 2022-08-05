using TrainerTraineeApp;

Organization org = new Organization();
Console.WriteLine("Enter org name");

org.Name = Console.ReadLine();

Trainer trainer = new Trainer();
trainer.TheOrganization = org;

Trainee t1 = new Trainee();
Trainee t2 = new Trainee();
Trainee t3 = new Trainee();
Trainee t4 = new Trainee();
Trainee t5 = new Trainee();

t1.Trainer = trainer;
t2.Trainer = trainer;
t3.Trainer = trainer;
t4.Trainer = trainer;
t5.Trainer = trainer;

Training training = new Training();
training.Trainer = trainer;
training.Trainees.Add(t1);
training.Trainees.Add(t2);
training.Trainees.Add(t3);
training.Trainees.Add(t4);
training.Trainees.Add(t5);

t1.Trainings.Add(training);
t2.Trainings.Add(training);
t3.Trainings.Add(training);
t4.Trainings.Add(training);
t5.Trainings.Add(training);

Course course = new Course();
training.Course = course;
course.Trainings.Add(training);


Module m1 = new Module();
Module m2 = new Module();
Module m3 = new Module();

course.Modules.Add(m1);
course.Modules.Add(m2);
course.Modules.Add(m3);

Unit u1 = new Unit();
u1.Duration = 50;
m1.Units.Add(u1);
Unit u2 = new Unit();
u2.Duration = 100;
m1.Units.Add(u2);
Unit u3 = new Unit();
u3.Duration = 120;
m2.Units.Add(u3);
Unit u4 = new Unit();
u4.Duration = 10;
m2.Units.Add(u4);
Unit u5 = new Unit();
u5.Duration = 56;
m3.Units.Add(u5);
Unit u6 = new Unit();
u6.Duration = 100;
m3.Units.Add(u6);
Unit u7 = new Unit();
u7.Duration = 25;
m3.Units.Add(u7);
Unit u8 = new Unit();
u8.Duration = 25;
m3.Units.Add(u8);


Console.WriteLine($"The org name: {training.GetTrainingOrgName()}");
Console.WriteLine($"Trainees count : {training.GetNoOfTrainees()}");
Console.WriteLine($"Duration (Hrs): {training.GetTrainingDurationInHrs() / 60}");