 static void Main(string[] args)
        {
            var fileContents = File.ReadAllLines(@"c:\projects\students.csv");
            var numberOfContacts = fileContents.Count();


            ContactInfo[] contacts = new ContactInfo[numberOfContacts];

            for (int i = 0; i < numberOfContacts; i++)
            {
                var line = fileContents[i];
                var linesplit = line.Split(new []{ ',' });

                contacts[i] = new ContactInfo();

                contacts[i].FName = linesplit[0];
                contacts[i].LName = linesplit[1];
                contacts[i].Email = linesplit[2];
            }

            foreach (var c in contacts)
            {
                Console.WriteLine($"Contact: {c.FName} {c.LName}. Their email is {c.Email}");
            }

            Console.ReadLine();
        }
