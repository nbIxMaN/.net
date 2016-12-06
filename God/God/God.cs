using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Security;

namespace God
{
    class God : IGod
    {
        enum HumanType
        {
            Student,
            Parent,
            Botan,
            CoolParent
        }
        private Random random = new Random();
        private string[] manName = { "Антон", "Максим", "Алксандр", "Глеб", "Зигмунд", "Константин" };
        private string[] womanName = { "Анна", "Виктория", "Екатерина", "Мария", "Любовь", "Юлия" };
        private List<Human> humans = new List<Human>();
        public List<Human> Humans
        {
            get
            {
                List<Human> cloneHumans = new List<Human>();
                humans.ForEach(cloneHumans.Add);
                return cloneHumans;
            }
        }
        private int minimalStudentAge = 16;
        private int minimalParentAge = 32;
        //private string[] middleName = { "Антонович", "Димунов", "Лимуров", "Жирафин", "Циннов", "Хорильный" };
        Sex[] sexArray = (Sex[])Enum.GetValues(typeof(Sex));
        HumanType[] manTypes = (HumanType[])Enum.GetValues(typeof(HumanType));
        HumanType[] womanTypes = { HumanType.Student, HumanType.Botan };
        public Human CreateHuman()
        {
            if (humans.Count == 0)
                return CreateHuman(Sex.male);
            else if (humans.Count == 1)
                return CreateHuman(Sex.female);
            else
                return CreateHuman(sexArray[random.Next(sexArray.Length)]);
        }

        public Human CreateHuman(Sex sex)
        {
            HumanType humanType;
            Human human = null;
            if (sex == Sex.female)
                humanType = womanTypes[random.Next(womanTypes.Length)];
            else
                humanType = manTypes[random.Next(manTypes.Length)];
            switch (humanType)
            {
                case HumanType.Student:
                    if (sex == Sex.male)
                        human = new Student(manName[random.Next(manName.Length)], manName[random.Next(manName.Length)] + "ович", minimalStudentAge + random.Next(8), sex);
                    else
                        human = new Student(womanName[random.Next(womanName.Length)], manName[random.Next(manName.Length)] + "овна", minimalStudentAge + random.Next(8), sex);
                    break;
                case HumanType.Parent:
                    human = new Parent(manName[random.Next(manName.Length)], minimalParentAge + random.Next(50), sex, random.Next(10));
                    break;
                case HumanType.Botan:
                    if (sex == Sex.male)
                        human = new Botan(manName[random.Next(manName.Length)], manName[random.Next(manName.Length)] + "ович", minimalStudentAge + random.Next(8), sex, 3 + random.Next(2) + random.NextDouble());
                    else
                        human = new Botan(womanName[random.Next(womanName.Length)], manName[random.Next(manName.Length)] + "овна", minimalStudentAge + random.Next(8), sex, 3 + random.Next(2) + random.NextDouble());
                    break;
                case HumanType.CoolParent:
                    human = new CoolParent(manName[random.Next(manName.Length)], minimalParentAge + random.Next(50), sex, random.Next(10), random.Next(99999) + random.NextDouble());
                    break;

            }
            if (human != null)
            {
                humans.Add(human);
                return human;
            }
            else
                throw new Exception();
        }
        public Human CreatePair(Human human)
        {
            if (human is Botan)
            {
                var botan = human as Botan;
                CoolParent coolParent;
                if (botan.Sex == Sex.male)
                    coolParent = new CoolParent(botan.MiddleName.Replace("ович", ""), minimalParentAge + random.Next(50), Sex.male, random.Next(10), Math.Pow(10, botan.AverageRating));
                else
                    coolParent = new CoolParent(botan.MiddleName.Replace("овна", ""), minimalParentAge + random.Next(50), Sex.male, random.Next(10), Math.Pow(10, botan.AverageRating));
                humans.Add(coolParent);
                return coolParent;
            }
            else if (human is CoolParent)
            {
                var coolParent = human as CoolParent;
                Botan botan;
                var sex = sexArray[random.Next(sexArray.Length)];
                if (sex == Sex.male)
                {
                    coolParent.NumberOfChild += 1;
                    botan = new Botan(manName[random.Next(manName.Length)], coolParent.Name + "ович", minimalStudentAge + random.Next(8), sex, Math.Log10(coolParent.Money));
                }
                else
                {
                    coolParent.NumberOfChild += 1;
                    botan = new Botan(womanName[random.Next(womanName.Length)], coolParent.Name + "овна", minimalStudentAge + random.Next(8), sex, Math.Log10(coolParent.Money));
                }
                humans.Add(botan);
                return botan;
            }
            else if (human is Student)
            {
                var student = human as Student;
                Parent parent;
                if (student.Sex == Sex.male)
                    parent = new Parent(student.MiddleName.Replace("ович", ""), minimalParentAge + random.Next(50), Sex.male, random.Next(10));
                else
                    parent = new Parent(student.MiddleName.Replace("овна", ""), minimalParentAge + random.Next(50), Sex.male, random.Next(10));
                humans.Add(parent);
                return parent;
            }
            else if (human is Parent)
            {
                var parent = human as Parent;
                Student student;
                var sex = sexArray[random.Next(sexArray.Length)];
                if (sex == Sex.male)
                {
                    parent.NumberOfChild += 1;
                    student = new Student(manName[random.Next(manName.Length)], parent.Name + "ович", minimalStudentAge + random.Next(8), sex);
                }
                else
                {
                    parent.NumberOfChild += 1;
                    student = new Student(womanName[random.Next(womanName.Length)], parent.Name + "овна", minimalStudentAge + random.Next(8), sex);
                }
                humans.Add(student);
                return student;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        private double Indexate(Human human)
        {
            CoolParent coolParent = human as CoolParent;
            if (coolParent != null)
                return coolParent.Money;
            else
                return 0;
        }
        public double GetTotalMoney()
        {
            double totalMoney = 0;
            foreach(Human human in humans)
            {
                totalMoney += Indexate(human);
            }
            return totalMoney;
        }
    }
}
