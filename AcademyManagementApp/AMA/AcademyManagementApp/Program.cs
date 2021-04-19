using System;
using System.Collections.Generic;
using ClassLibrary.Models;
using ClassLibrary.Enums;
using Academy_Services.GeneralSerices;
using Academy_Services.StudentServices;
using Academy_Services.TrainerServices;
using Academy_Services.AdminServices;



using System.Linq;



namespace AcademyManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Admin nadja = new Admin("Mila", "Mihajlova", 27, "milaa01", "Milaa01", "mila.Mihajlova@gmail.com", 78435552);
            List<Member> allMembers = new List<Member>()
            {
             new Student("Jelena", "Nakova", 31, "jelena01","Jelena01", "jelenanakova@outlook.com", 75434987,new Dictionary<AcademySubject, int>() {{ AcademySubject.BasicProgrammingPrinciples, 8 },{ AcademySubject.HTML5_CSS3, 6 },{ AcademySubject.BasicJavaScript, 6 },{ AcademySubject.AdvancedJavaScript, 7 },{AcademySubject.BasicCSharp,8 }}, AcademySubject.AdvancedCSharp, AcademyGroup.G4),
             new Student("Angel", "Jordanovski", 31, "angel01","Angel01", "angeljordanovski@gmail.com", 75484987,new Dictionary<AcademySubject, int>() {{ AcademySubject.BasicProgrammingPrinciples, 10 },{ AcademySubject.HTML5_CSS3, 10 },{ AcademySubject.BasicJavaScript, 8 },{ AcademySubject.AdvancedJavaScript, 9},{AcademySubject.BasicCSharp,9 } },AcademySubject.AdvancedCSharp, AcademyGroup.G1),

             new Student("Ljubica", "Jakimovska", 22, "ljubica01",
                "Ljubica01", "ljubica_jakimovska@gmail.com", 75434112,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples, 6 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 5 },
                { AcademySubject.AdvancedJavaScript, 8},
                {AcademySubject.BasicCSharp,10 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G2),

             new Student("Vlatko", "Tomevski", 31, "vlatko01",
                "Vlatko01", "tomevskiv@gmail.com", 70004112,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,10 },
                { AcademySubject.HTML5_CSS3, 9 },
                { AcademySubject.BasicJavaScript, 8 },
                { AcademySubject.AdvancedJavaScript, 7},
                {AcademySubject.BasicCSharp,6 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G3),

             new Student("Nikola", "Petrov", 31, "nikola01",
                "Nikola01", "petrovN@gmail.com", 76804112,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,5 },
                { AcademySubject.HTML5_CSS3, 6 },
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 8},
                {AcademySubject.BasicCSharp,9 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G4),

             new Student("Darko", "Stojanovski", 25, "darko01",
                "Darko01", "darko_sto@gmail.com", 70223305,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,7 },
                { AcademySubject.HTML5_CSS3, 5 },
                { AcademySubject.BasicJavaScript, 8 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,6 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G1),

             new Student("Aleksandar", "Manasov", 27, "aleksandar01",
                "Aleksandar01", "manasov05@gmail.com", 72757698,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,10 },
                { AcademySubject.HTML5_CSS3, 9 },
                { AcademySubject.BasicJavaScript, 10 },
                { AcademySubject.AdvancedJavaScript, 8},
                {AcademySubject.BasicCSharp,7 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G2),

             new Student("Vlatko", "Vasilev", 31, "vlatko02",
                "Vlatko02", "tomevskiv@gmail.com", 71009112,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,6 },
                { AcademySubject.HTML5_CSS3, 7 },
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 7},
                {AcademySubject.BasicCSharp,6 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G3),
             new Student("Milena", "Aritonova", 31, "milena01",
                "Milena01", "milenaArit@gmail.com", 72446987,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,8 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 10 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,6 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G4),
             new Student("Stefani", "Ivanova", 31, "stefani01",
                "Stefani01", "ianovaS@yahoo.com", 777091337,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,6 },
                { AcademySubject.HTML5_CSS3, 7 },
                { AcademySubject.BasicJavaScript, 6 },
                { AcademySubject.AdvancedJavaScript, 7},
                {AcademySubject.BasicCSharp,6 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G1),
              new Student("Ana", "Vasileva", 20, "anaana01",
                "Anaana01", "vasilevaa@outlook.com", 787051337,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,5 },
                { AcademySubject.HTML5_CSS3, 6 },
                { AcademySubject.BasicJavaScript, 6 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,7}
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G2),
              new Student("Viktor", "Indov", 28, "viktor01",
                "Viktor01", "viktorV@outlook.com", 777054237,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,8 },
                { AcademySubject.HTML5_CSS3, 6 },
                { AcademySubject.BasicJavaScript, 5 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,10}
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G3),
               new Student("Anastasija", "Nikova", 38, "anastasija01",
                "Anastasija01", "nikovaAn@gmail.com", 70021987,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples, 9 },
                { AcademySubject.HTML5_CSS3, 7 },
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 8 },
                {AcademySubject.BasicCSharp,9 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G4),

             new Student("Luka", "Jordanovski", 31, "luka01",
                "Luka01", "lukajordanovski@gmail.com", 70444987,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples, 6 },
                { AcademySubject.HTML5_CSS3, 6},
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 8},
                {AcademySubject.BasicCSharp,7 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G1),

             new Student("Andrej", "Janev", 27, "andrej01",
                "Andrej01", "andrej_janev@gmail.com", 70000262,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples, 7 },
                { AcademySubject.HTML5_CSS3, 10 },
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 10},
                {AcademySubject.BasicCSharp,5 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G2),

             new Student("Marko", "Apostolov", 29, "marko02",
                "Marko02", "markoApostolov@yahoo.com", 75002112,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,10 },
                { AcademySubject.HTML5_CSS3, 9 },
                { AcademySubject.BasicJavaScript, 10 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,8 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G3),

             new Student("Nikola", "Zfirovski", 34, "nikola03",
                "Nikola03", "zafNik@gmail.com", 75805552,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,6 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 10 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,5 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G4),

             new Student("Darko", "Divjakovski", 29, "darko02",
                "Darko02", "darko_sto@gmail.com", 71223405,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,7 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 8 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,7 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G1),

             new Student("Aleksandra", "Rizovska", 27, "aleksandra01",
                "Aleksandra01", "rizovska05@gmail.com", 71111648,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,6 },
                { AcademySubject.HTML5_CSS3, 6 },
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 8},
                {AcademySubject.BasicCSharp,7 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G2),

             new Student("Vladimir", "Todev", 31, "vladimir01",
                "Vladimir01", "todev@gmail.com", 70226712,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,9 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 9 },
                { AcademySubject.AdvancedJavaScript, 10},
                {AcademySubject.BasicCSharp,9 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G3),
             new Student("Monika", "Petrova", 31, "monika01",
                "Monika01", "monikaPetrova@gmail.com", 71436987,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,8 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 10 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,6 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G4),
             new Student("Stefan", "Manev", 31, "stefan01",
                "Stefan01", "stefan_manevS@yahoo.com", 71231337,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,6 },
                { AcademySubject.HTML5_CSS3, 7 },
                { AcademySubject.BasicJavaScript, 8 },
                { AcademySubject.AdvancedJavaScript, 7},
                {AcademySubject.BasicCSharp,10 }
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G1),
              new Student("Trajhce", "Vaskov", 27, "trajce01",
                "Trajce01", "vaskov_00@outlook.com", 757051337,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,5 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 5 },
                { AcademySubject.AdvancedJavaScript, 9},
                {AcademySubject.BasicCSharp,7}
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G2),
              new Student("Todor ", "Mitev", 28, "todor01",
                "Todor01", "todorV@outlook.com", 75724237,
                new Dictionary<AcademySubject, int>() {
                { AcademySubject.BasicProgrammingPrinciples,6 },
                { AcademySubject.HTML5_CSS3, 8 },
                { AcademySubject.BasicJavaScript, 7 },
                { AcademySubject.AdvancedJavaScript, 7},
                {AcademySubject.BasicCSharp,8}
                 },
                AcademySubject.AdvancedCSharp, AcademyGroup.G3),

              new Trainer("Jovana", "Jovanovska", 36, "jovana01", "Jovana01","jovanovska_j@gmail.com",075306778,new List<AcademySubject>()
                { AcademySubject.HTML5_CSS3,
                  AcademySubject.BasicProgrammingPrinciples,
                  AcademySubject.BasicJavaScript,
                  AcademySubject.AdvancedJavaScript,
                  AcademySubject.BasicCSharp,
                  AcademySubject.RelationalDatabases,
                  AcademySubject.AdvancedCSharp},AcademySubject.AdvancedCSharp,AcademyGroup.G3,"Ilija Jovanov"),
              new Trainer("Daniel", "Stefanov", 42, "daniel01", "Daniel01","stefanov_d@gmail.com",070802778,new List<AcademySubject>()
            {   AcademySubject.HTML5_CSS3,
                AcademySubject.AdvancedCSharp,
                AcademySubject.RelationalDatabases,
                AcademySubject.DevelopingAspDotNETApps,
                AcademySubject.RESTfulWebServices,
                AcademySubject.AdvancedDataDrivenApps,
                AcademySubject.SoftwareDebuggingAndTesting,
                AcademySubject.DevelopingCloudReadyApplications,
                AcademySubject.CSharpServerDevelopment,
                AcademySubject.MEAN_MERNDevelopment,
               AcademySubject.AngularJSWithTypeScript},AcademySubject.AdvancedCSharp,AcademyGroup.G1,"Viktorija Doneva"),
             new Trainer("Daniela", "Mishevska", 32, "daniela01", "Daniela01","d_mishevska@gmail.com",071892778,new List<AcademySubject>()
            { AcademySubject.HTML5_CSS3,
            AcademySubject.BasicProgrammingPrinciples,
             AcademySubject.RelationalDatabases,
             AcademySubject.AdvancedCSharp,
             AcademySubject.DevelopingAspDotNETApps,
                AcademySubject.RESTfulWebServices,
                AcademySubject.AdvancedDataDrivenApps,
                AcademySubject.SoftwareDebuggingAndTesting
             },AcademySubject.AdvancedCSharp,AcademyGroup.G2,"Elena Zafirova"),

         new Trainer("Denis", "Novkov", 42, "denis01", "Denis01", "novkov_d@gmail.com", 071802778, new List<AcademySubject>()
            { AcademySubject.HTML5_CSS3,
              AcademySubject.BasicProgrammingPrinciples,
               AcademySubject.BasicJavaScript,
                  AcademySubject.AdvancedJavaScript,
                  AcademySubject.BasicCSharp,
                   AcademySubject.RelationalDatabases,
                  AcademySubject.AdvancedCSharp,
                   AcademySubject.DevelopingCloudReadyApplications,
                AcademySubject.CSharpServerDevelopment,
                AcademySubject.MEAN_MERNDevelopment,
               AcademySubject.AngularJSWithTypeScript
             }, AcademySubject.AdvancedCSharp, AcademyGroup.none, "Viktorija Doneva"),


              new Trainer("Radica", "Todorovska", 35, "radica01", "Radica01", "todorovska_r@gmail.com", 075776778, new List<AcademySubject>()
                {
                  AcademySubject.BasicProgrammingPrinciples,
                   AcademySubject.BasicJavaScript,
                  AcademySubject.AdvancedJavaScript,
                  AcademySubject.BasicCSharp,
                   AcademySubject.RelationalDatabases,
                  AcademySubject.DevelopingAspDotNETApps,
                AcademySubject.RESTfulWebServices,
                AcademySubject.AdvancedDataDrivenApps,
                AcademySubject.SoftwareDebuggingAndTesting,
                 AcademySubject.DevelopingCloudReadyApplications,
                AcademySubject.CSharpServerDevelopment,
                AcademySubject.MEAN_MERNDevelopment,
               AcademySubject.AngularJSWithTypeScript,

                  AcademySubject.AdvancedCSharp}, AcademySubject.AdvancedCSharp, AcademyGroup.G4, "Ljubomir Jovanov"),
              new Trainer("Ivana", "Markovska", 34, "ivana01", "Ivana01", "Markovska_I@gmail.com", 071302778, new List<AcademySubject>()
            { AcademySubject.HTML5_CSS3,
                  AcademySubject.BasicProgrammingPrinciples,
                   AcademySubject.BasicJavaScript,
                  AcademySubject.AdvancedJavaScript,
                  AcademySubject.BasicCSharp,
                  AcademySubject.DevelopingAspDotNETApps,
                AcademySubject.RESTfulWebServices,
                AcademySubject.AdvancedDataDrivenApps,
                AcademySubject.SoftwareDebuggingAndTesting,
                 AcademySubject.DevelopingCloudReadyApplications,
                AcademySubject.CSharpServerDevelopment,
                AcademySubject.MEAN_MERNDevelopment,
               AcademySubject.AngularJSWithTypeScript

              },AcademySubject.none, AcademyGroup.none, "Sandra Noneva"),
            new Trainer("Boban", "Mitevski", 26, "boban01", "Daniela01", "b_mitevski@gmail.com", 072092778, new List<AcademySubject>()
            { AcademySubject.HTML5_CSS3,
                  AcademySubject.BasicProgrammingPrinciples,
                   AcademySubject.BasicJavaScript,
                  AcademySubject.AdvancedJavaScript,
                  AcademySubject.BasicCSharp,
                  AcademySubject.DevelopingAspDotNETApps,
                AcademySubject.RESTfulWebServices,
                AcademySubject.AdvancedDataDrivenApps,
                AcademySubject.SoftwareDebuggingAndTesting,
                 AcademySubject.DevelopingCloudReadyApplications,
                AcademySubject.CSharpServerDevelopment,
                AcademySubject.MEAN_MERNDevelopment,
               AcademySubject.AngularJSWithTypeScript

              }, AcademySubject.none, AcademyGroup.G5, "Elena Zafirova"),
            new Admin("Mila", "Mihajlova", 27, "milaa01", "Milaa01", "mila.Mihajlova@gmail.com", 78435552),
            new Admin("Marko", "Nakov", 28, "marko01", "Marko01", "marko.Nakov@gmail.com", 78470152),
            new Admin("Lina", "Mihajlova", 24, "linaaa01", "Linaa01", "lina.Mihajlova@gmail.com", 70135952) };




            //HERE STARTS THE LOGIC:
            try
            {

                while (true)
                {
                    switch (GeneralServicies.BasicLoginMenu())
                    {
                        case "adminLogin":
                            Admin adminActive = AdminServices.DiplayLoginForAdmin(allMembers);
                            while (true)
                            {
                                if (adminActive == null) break;
                                AdminServices.AdminDisplayMenu(adminActive);
                                string userInput = Console.ReadLine();
                                if (userInput == "x") break;
                                switch (userInput)
                                {
                                    case "1":
                                        AdminServices.DisplayUsers(allMembers);
                                        break;
                                    case "2":
                                        AdminServices.DisplaySubjects(allMembers);
                                        break;
                                    case "3":
                                        AdminServices.AddNewUser(allMembers);
                                        break;
                                    case "4":
                                        AdminServices.DisplayForRemovigUsers(allMembers, adminActive);
                                        break;

                                }
                            }
                            break;
                        case "trainerLogin":
                            Trainer trainerActive = TrainerServices.DisplayTrainerLogin(allMembers);
                            while (true)
                            {

                                if (trainerActive == null) break;
                                TrainerServices.TrainerDisplayMenu(trainerActive);
                                string userInput = Console.ReadLine();
                                if (userInput == "x") break;
                                switch (userInput)
                                {
                                    case "1":
                                        TrainerServices.DisplayTrainerInfo(trainerActive);
                                        break;
                                    case "2":
                                        TrainerServices.DisplaySubjectsTeaching(trainerActive);
                                        break;
                                    case "3":
                                        TrainerServices.DisplayCurrentSubject(trainerActive);
                                        break;
                                    case "4":
                                        TrainerServices.CheckYourGroup(trainerActive, allMembers);
                                        break;
                                    case "x":
                                        break;
                                }

                            }
                            break;

                        case "studentLogin":
                            Student studentActive = StudentServices.DisplayStudentLogin(allMembers);

                            while (true)
                            {
                                if (studentActive == null) break;
                                StudentServices.StudentDisplayMenu(studentActive);
                                string userInput = Console.ReadLine();
                                if (userInput == "x") break;
                                switch (userInput)
                                {
                                    case "1":
                                        StudentServices.DisplayPassedSubjects(studentActive);
                                        break;
                                    case "2":
                                        StudentServices.SubjectsCurrentlyListened(studentActive, allMembers);
                                        break;
                                    case "3":
                                        StudentServices.SubjectsLeft(studentActive);
                                        break;
                                    case "4":
                                        StudentServices.CheckYourGroup(studentActive, allMembers);
                                        break;
                                    case "x":
                                        break;
                                }
                            }
                            break;

                        case "regularLogin":
                            Console.WriteLine("Underconstruction!");
                            break;

                        case "":
                            break;


                    }
                }

            }
            catch ( Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Everything is done!");
            }




            
        }
               









        }



}

