using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    internal class God : IGod
    {
        private readonly List<IHasName> _humans = new List<IHasName>();

        public List<IHasName> Humans
        {
            get
            {
                List<IHasName> cloneHumans = new List<IHasName>();
                _humans.ForEach(cloneHumans.Add);
                return cloneHumans;
            }
        }

        public Human CreateHuman()
        {
            switch (_humans.Count)
            {
                case 0:
                    return CreateHuman(Sex.male);
                case 1:
                    return CreateHuman(Sex.female);
                default:
                    return CreateHuman(RandomHelper.GetRandomSex());
            }
        }

        public Human CreateHuman(Sex sex)
        {
            Human human = null;
            var humanType = sex == Sex.female ? RandomHelper.GetRandomWomanType() : RandomHelper.GetRandomManType();
            switch (humanType)
            {
                case HumanType.Botan:
                    human = new Botan(RandomHelper.GetRandomManName(), RandomHelper.GetRandomManMiddleName(),
                        RandomHelper.GetRandomAge(), RandomHelper.GetRandomAverageRating());
                    break;
                case HumanType.Student:
                    human = new Student(RandomHelper.GetRandomManName(), RandomHelper.GetRandomManMiddleName(),
                        RandomHelper.GetRandomAge());
                    break;
                case HumanType.Girl:
                    human = new Girl(RandomHelper.GetRandomWomanName(), RandomHelper.GetRandomWomanMiddleName(),
                        RandomHelper.GetRandomAge());
                    break;
                case HumanType.PrettyGirl:
                    human = new PrettyGirl(RandomHelper.GetRandomWomanName(), RandomHelper.GetRandomWomanMiddleName(),
                        RandomHelper.GetRandomAge());
                    break;
                case HumanType.SmartGirl:
                    human = new SmartGirl(RandomHelper.GetRandomWomanName(), RandomHelper.GetRandomWomanMiddleName(),
                        RandomHelper.GetRandomAge());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            _humans.Add(human);
            return human;
        }

        public IHasName Couple(Human firstHuman, Human secondHuman)
        {
            if (firstHuman.Sex != secondHuman.Sex)
            {
                var firstcoupleAttribute = ((CoupleAttribute[])
                        Attribute.GetCustomAttributes(firstHuman.GetType(), typeof(CoupleAttribute), false))
                    .First(x => x.Pair.Equals(secondHuman.GetType().Name));
                var secondcoupleAttribute = ((CoupleAttribute[])
                        Attribute.GetCustomAttributes(secondHuman.GetType(), typeof(CoupleAttribute), false))
                    .First(x => x.Pair.Equals(firstHuman.GetType().Name));
                firstHuman.InLove = RandomHelper.Random.NextDouble() <= firstcoupleAttribute.Probability;
                secondHuman.InLove = RandomHelper.Random.NextDouble() <= secondcoupleAttribute.Probability;
                var getNameMethod = secondHuman.GetType()
                    .GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                    .First(x => x.ReturnType == typeof(string));
                if (!firstHuman.InLove || !secondHuman.InLove) return null;
                {
                    try
                    {
                        var name = (string) getNameMethod.Invoke(secondHuman, null);
                        IHasName returned = null;
                        switch (firstcoupleAttribute.ChildType)
                        {
                            case "Book":
                                returned = new Book();
                                break;
                            case "Girl":
                                returned = new Girl();
                                break;
                            case "PrettyGirl":
                                returned = new PrettyGirl();
                                break;
                            case "SmartGirl":
                                returned = new SmartGirl();
                                break;
                            case "Botan":
                                returned = new Botan();
                                break;
                            case "Student":
                                returned = new Student();
                                break;
                        }
                        if (returned != null)
                        {
                            returned.GetType()
                                .GetProperties()
                                .First(x => x.Name.Equals("Name"))
                                .SetValue(returned, name);
                            try
                            {
                                Human man;
                                if (firstHuman.Sex == Sex.male)
                                {
                                    man = firstHuman;
                                }
                                else
                                {
                                    man = secondHuman;
                                }
                                if (
                                    (Sex)
                                    returned.GetType()
                                        .GetProperties()
                                        .First(x => x.Name.Equals("Sex"))
                                        .GetValue(returned) == Sex.male)
                                    returned.GetType()
                                        .GetProperties()
                                        .First(x => x.Name.Equals("MiddleName"))
                                        .SetValue(returned, man.Name + "ович");
                                else
                                    returned.GetType()
                                        .GetProperties()
                                        .First(x => x.Name.Equals("MiddleName"))
                                        .SetValue(returned, man.Name + "овна");
                            }
                            catch (SystemException)
                            {
                            }
                            _humans.Add(returned);
                            return returned;
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
            else
                throw new HomosexualExeption();
            return null;
        }
    }
}