using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            return valuables.FirstOrDefault(v =>
                (v is Merchandise m && m.ItemId == id) ||
                (v is Course c && c.Name == id));
        }

        public double GetTotalValue()
        {
            return valuables.Sum(v => v.GetValue());
        }

        public int Count()
        {
            return valuables.Count;
        }

        public void Save()
        {
            Save("Valuabley.txt");
        }

        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (IValuable valuable in valuables)
                {
                    switch (valuable)
                    {
                        case Book book:
                            writer.WriteLine($"BOG;{book.ItemId};{book.Title};{book.GetValue()}");
                            break;
                        case Amulet amulet:
                            writer.WriteLine($"AMULET;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                            break;
                        case Course course:
                            writer.WriteLine($"COURSE;{course.Name};{course.DurationInMinutes}");
                            break;
                    }
                }
            }
        }

        public void Load()
        {
            Load("Valuabley.txt");
        }

        public void Load(string filename)
        {
            try
            {
                valuables.Clear();

                using (StreamReader reader = new StreamReader(filename))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(line)) continue;

                        string[] parts = line.Split(';');
                        if (parts.Length < 2) continue;

                        switch (parts[0].ToUpper())
                        {
                            case "BOG" when parts.Length >= 4:
                                valuables.Add(new Book(parts[1], parts[2], Convert.ToDouble(parts[3])));
                                break;

                            case "AMULET" when parts.Length >= 4:
                                if (Enum.TryParse(parts[2], out Level quality))
                                {
                                    valuables.Add(new Amulet(parts[1], quality, parts[3]));
                                }
                                break;

                            case "COURSE" when parts.Length >= 3:
                                valuables.Add(new Course(parts[1], Convert.ToInt32(parts[2])));
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
                throw; // Re-throw the exception to maintain the original behavior
            }
        }
    }

}
