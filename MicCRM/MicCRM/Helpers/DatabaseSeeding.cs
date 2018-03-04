using MicCRM.Data;
using MicCRM.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicCRM.Helpers
{
    public static class DatabaseSeeding
    {
        public static void Seed(ApplicationDbContext dBContext)
        {
            if ((dBContext.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
                return;

            dBContext.Database.Migrate();

            if (dBContext.Applicants.Any())
                return;

            List<Technology> technologiesList = new List<Technology>()
            {
                new Technology()
                {
                    Name = "Programming fundamentals-Evening hours"
                },
                new Technology()
                {
                    Name = "Programming fundamentals-Afternoon hour"
                },
                new Technology()
                {
                    Name = "Object-oriented programming with C# and .NET Framework"
                },
                new Technology()
                {
                    Name = "ASP MVC back-end programming"
                },
                new Technology()
                {
                    Name = "Introduction to JavaScript"
                },
                new Technology()
                {
                    Name = "Advanced JavaScript and JS Frameworks"
                },
                new Technology()
                {
                    Name = "QA Fundamentals"
                },
                new Technology()
                {
                    Name = "UI/UX Design"
                },
                new Technology()
                {
                    Name = "Introduction to Python"
                },
                new Technology()
                {
                    Name = "Network administration"
                },
            };
            dBContext.Technologies.AddRange(technologiesList);

            Teacher teacher1 = new Teacher()
            {
                FirstName = "Levon",
                LastName = "Hovhanisyan",
                Phone = "099999999",
                Email = "lev.hov@gmail.com"
            };
            dBContext.Teachers.Add(teacher1);

            Teacher teacher2 = new Teacher()
            {
                FirstName = "Arayik",
                LastName = "Melqonyan",
                Phone = "077777777",
                Email = "ar.melq@gmail.com"
            };
            dBContext.Teachers.Add(teacher2);

            Lesson lesson1 = new Lesson()
            {
                Teacher = teacher1,
                Technology = technologiesList[3],
                StartingDate = DateTime.Now,
                EndingDate = DateTime.Now,
            };
            dBContext.Lessons.Add(lesson1);

            Lesson lesson2 = new Lesson()
            {
                Teacher = teacher2,
                Technology = technologiesList[2],
                StartingDate = DateTime.Now,
                EndingDate = DateTime.Now,
            };
            dBContext.Lessons.Add(lesson2);

            Applicant applicant1 = new Applicant()
            {
                FirstName = "On",
                LastName = "Asoyan",
                Phone1 = "+37477617517",
                Email = "media-onix@mail.ru",
                Description = "aklajsklajlkjl",
                Date = new DateTime(2018, 10, 12),
                Lesson = lesson1,
            };
            dBContext.Applicants.Add(applicant1);

            Applicant applicant2 = new Applicant()
            {
                FirstName = "Suren",
                LastName = "Avagyan",
                Phone1 = "+37498252525",
                Email = "surenavagyan@gmail.com",
                Description = "Suro",
                Date = new DateTime(2018, 10, 12),
                Lesson = lesson2,
            };
            dBContext.Applicants.Add(applicant2);

            dBContext.SaveChanges();
        }
    }
}
