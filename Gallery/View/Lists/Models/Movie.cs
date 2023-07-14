using Microsoft.Maui.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.View.Lists.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

    public class GroupMovie : List<Movie>
    {
        public string CompanyName { get; set; }

    }
    public static class MovieList
    {
        public static List<GroupMovie> GetGroupList()
        {
            var disneyGroup = new GroupMovie { CompanyName = "Disney+" };
            disneyGroup.Add(new Movie()
            {
                Id = 1,
                Name = "Emancipation",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 12, 0),
                LaunchYear = 2022
            });
            disneyGroup.Add(new Movie()
            {
                Id = 2,
                Name = "Tudo em Todo Lugar ao Mesmo Tempo",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 19, 0),
                LaunchYear = 2022
            });
            disneyGroup.Add(new Movie()
            {
                Id = 3,
                Name = "O Menu",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 46, 0),
                LaunchYear = 2022
            });

            var ParamountGroup = new GroupMovie { CompanyName = "Paramount" };
            ParamountGroup.Add(new Movie()
            {
                Id = 4,
                Name = "Não, Não Olhe!",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 10, 0),
                LaunchYear = 2022
            });
            ParamountGroup.Add(new Movie()
            {
                Id = 5,
                Name = "Irmãos de Honra",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 19, 0),
                LaunchYear = 2022
            });
            ParamountGroup.Add(new Movie()
            {
                Id = 6,
                Name = "Trem Bala",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 6, 0),
                LaunchYear = 2022
            });
            ParamountGroup.Add(new Movie()
            {
                Id = 7,
                Name = "The Pale Blue Eye",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 8, 0),
                LaunchYear = 2022
            });

            var universal = new GroupMovie { CompanyName = "Universal" };
            universal.Add(new Movie()
            {
                Id = 8,
                Name = "Casamento Armado",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 40, 0),
                LaunchYear = 2022
            });
            universal.Add(new Movie()
            {
                Id = 9,
                Name = "Sorria",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 55, 0),
                LaunchYear = 2022
            });
            universal.Add(new Movie()
            {
                Id = 10,
                Name = "O Telefone Preto",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 42, 0),
                LaunchYear = 2021
            });

            List<GroupMovie> List = new List<GroupMovie>()
            {
                disneyGroup,
                ParamountGroup,
                universal,
            };

            return List;
        }
        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();
            list.Add(new Movie()
            {
                Id = 1,
                Name = "Emancipation",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 12, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 2,
                Name = "Tudo em Todo Lugar ao Mesmo Tempo",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 19, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 3,
                Name = "O Menu",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 46, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 4,
                Name = "Não, Não Olhe!",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 10, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 5,
                Name = "Irmãos de Honra",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 19, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 6,
                Name = "Trem Bala",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 6, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 7,
                Name = "The Pale Blue Eye",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(2, 8, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 8,
                Name = "Casamento Armado",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 40, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 9,
                Name = "Sorria",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 55, 0),
                LaunchYear = 2022
            });
            list.Add(new Movie()
            {
                Id = 10,
                Name = "O Telefone Preto",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                Duration = new TimeSpan(1, 42, 0),
                LaunchYear = 2021
            });

            return list;
        }
    }
}