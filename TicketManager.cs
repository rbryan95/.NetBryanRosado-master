using System.Globalization;

class TicketManager
    {
         // Specify the file paths for each CSV file
        private static string bugDefectsFile = "BugsDefects.csv";
        private static string enhancementsFile = "Enhancements.csv";
        private static string tasksFile = "Tasks.csv";
        public static void AddBugDefectTicket()
        {
            //User Input
            Console.Write("Enter TicketID: ");
            string ticketID = Console.ReadLine();
            Console.Write("Enter Summary: ");
            string summary = Console.ReadLine();
            Console.Write("Enter Status: ");
            string status = Console.ReadLine();
            Console.Write("Enter Priority: ");
            string priority = Console.ReadLine();
            Console.Write("Enter Submitter: ");
            string submitter = Console.ReadLine();
            Console.Write("Enter Assigned: ");
            string assigned = Console.ReadLine();
            Console.Write("Enter Watching: ");
            string watching = Console.ReadLine();
            Console.Write("Enter Severity: ");
            string severity = Console.ReadLine();

            //object
            var bugDefectTicket = new BugDefectTicket(ticketID, summary, status, priority, submitter, assigned, watching, severity);
            //csv file
            bool bugDefectsFileExists = File.Exists(bugDefectsFile);
            using (StreamWriter writer = new StreamWriter(bugDefectsFile, true))
            {
                if (!bugDefectsFileExists)
                {
                    writer.WriteLine("TicketID,Summary,Status,Priority,Submitter,Assigned,Watching,Severity");
                }
                writer.WriteLine($"{bugDefectTicket.TicketID},{bugDefectTicket.Summary},{bugDefectTicket.Status},{bugDefectTicket.Priority},{bugDefectTicket.Submitter},{bugDefectTicket.Assigned},{bugDefectTicket.Watching},{bugDefectTicket.Severity}");
            }

            Console.WriteLine("Bug/Defect Ticket added successfully.");
        
        }
                    //Engancement Ticket Data
                    public static void AddEnhancementTicket()
        {
            //User Input
            Console.Write("Enter TicketID: ");
            string ticketID = Console.ReadLine();
            Console.Write("Enter Summary: ");
            string summary = Console.ReadLine();
            Console.Write("Enter Status: ");
            string status = Console.ReadLine();
            Console.Write("Enter Priority: ");
            string priority = Console.ReadLine();
            Console.Write("Enter Submitter: ");
            string submitter = Console.ReadLine();
            Console.Write("Enter Assigned: ");
            string assigned = Console.ReadLine();
            Console.Write("Enter Watching: ");
            string watching = Console.ReadLine();
            Console.Write("Enter Software: ");
            string software = Console.ReadLine();
            Console.Write("Enter Cost: ");
           
           //obj 
            if (double.TryParse(Console.ReadLine(), out double enhancementCost))
            {
                Console.Write("Enter Reason: ");
                string reason = Console.ReadLine();
                Console.Write("Enter Estimate: ");
                if (double.TryParse(Console.ReadLine(), out double estimate))
                {
                    var enhancementTicket = new EnhancementTicket(ticketID, summary, status, priority, submitter, assigned, watching, software, enhancementCost, reason, estimate);


                    //Enhancement Ticket CVS File
                    bool enhancementsFileExists = File.Exists(enhancementsFile);
                    using (StreamWriter writer = new StreamWriter(enhancementsFile, true))
                    {
                        if(!enhancementsFileExists)
                        {
                            writer.WriteLine("TicketID,Summary,Status,Priority,Submitter,Assigned,Watching,Software,Cost,Reason,Estimate");
                        }
                        writer.WriteLine($"{enhancementTicket.TicketID},{enhancementTicket.Summary},{enhancementTicket.Status},{enhancementTicket.Priority},{enhancementTicket.Submitter},{enhancementTicket.Assigned},{enhancementTicket.Watching},{enhancementTicket.Software},{enhancementTicket.Cost},{enhancementTicket.Reason},{enhancementTicket.Estimate}");
                    }

                    Console.WriteLine("Enhancement Ticket added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid Estimate value. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Cost value. Please enter a valid number.");
            }
        }
                    
    public static void AddTaskTicket()
        {
            // User Input
            Console.Write("Enter TicketID: ");
            string ticketID = Console.ReadLine();
            Console.Write("Enter Summary: ");
            string summary = Console.ReadLine();
            Console.Write("Enter Status: ");
            string status = Console.ReadLine();
            Console.Write("Enter Priority: ");
            string priority = Console.ReadLine();
            Console.Write("Enter Submitter: ");
            string submitter = Console.ReadLine();
             Console.Write("Enter Assigned: ");
            string assigned = Console.ReadLine();
            Console.Write("Enter Watching: ");
            string watching = Console.ReadLine();
            Console.Write("Enter Project Name: ");
            string projectName = Console.ReadLine();
            Console.Write("Enter Due Date (yyyy-MM-dd): ");
           
             //OBJ 
            
                //CSV files exsit and add headers to new file 
            bool tasksFileExists = File.Exists(tasksFile); 
            using (StreamWriter writer = new StreamWriter(tasksFile, true))
            {
               //if (DateTime.TryParseExact(dueDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDueDate))
                TaskTicket taskTicket;
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newDueDate))
                {
                    taskTicket = new TaskTicket(ticketID, summary, status, priority, submitter, assigned, watching, projectName, newDueDate);
                    if (!tasksFileExists)
                    {
                        writer.WriteLine("TicketID,Summary,Status,Priority,Submitter,Assigned,Watching,ProjectName,DueDate");
                    }
                    writer.WriteLine($"{taskTicket.TicketID},{taskTicket.Summary},{taskTicket.Status},{taskTicket.Priority},{taskTicket.Submitter},{taskTicket.Assigned},{taskTicket.Watching},{taskTicket.ProjectName},{taskTicket.DueDate:yyyy-MM-dd}");

                    Console.WriteLine("Task Ticket added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid Due Date format. Please enter a valid date (yyyy-MM-dd).");
                }
            }
        }

        public static void SearchTickets()
        {
            Console.WriteLine("Search by (1) Status, (2) Priority, or (3) Submitter: ");
            string searchBy = Console.ReadLine();
            Console.Write("Enter search term: ");
            string searchTerm = Console.ReadLine();

            var searchResults = new List<Ticket>();

            if (searchBy == "1")
            {
                searchResults.AddRange(SearchTicketsInFile(bugDefectsFile, searchTerm, "Status"));
                searchResults.AddRange(SearchTicketsInFile(enhancementsFile, searchTerm, "Status"));
                searchResults.AddRange(SearchTicketsInFile(tasksFile, searchTerm, "Status"));
            }
            else if (searchBy == "2")
            {
                searchResults.AddRange(SearchTicketsInFile(bugDefectsFile, searchTerm, "Priority"));
                searchResults.AddRange(SearchTicketsInFile(enhancementsFile, searchTerm, "Priority"));
                searchResults.AddRange(SearchTicketsInFile(tasksFile, searchTerm, "Priority"));
            }
            else if (searchBy == "3")
            {
                searchResults.AddRange(SearchTicketsInFile(bugDefectsFile, searchTerm, "Submitter"));
                searchResults.AddRange(SearchTicketsInFile(enhancementsFile, searchTerm, "Submitter"));
                searchResults.AddRange(SearchTicketsInFile(tasksFile, searchTerm, "Submitter"));
            }

            if (searchResults.Count > 0)
            {
                Console.WriteLine("Search Results:");
                foreach (var ticket in searchResults)
                {
                    Console.WriteLine($"TicketID: {ticket.TicketID}, Summary: {ticket.Summary}");
                }
                Console.WriteLine($"Number of Matches: {searchResults.Count}");
            }
            else
            {
                Console.WriteLine("No matching tickets found.");
            }
        }
           private static List<Ticket> SearchTicketsInFile(string filePath, string searchTerm, string propertyToSearch)
        {
            var searchResults = new List<Ticket>();

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string headerLine = reader.ReadLine(); // Read and discard the header line
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(',');


                        if (propertyToSearch == "Status" && parts[2].Contains(searchTerm)  || propertyToSearch == "Submitter" && parts[4].Contains(searchTerm) || propertyToSearch == "Priority" && parts[3].Contains(searchTerm))
                        {
                            var ticket = new Ticket(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                            searchResults.Add(ticket);
                        }
                    }
                }
            }

            return searchResults; 

    }
    }
