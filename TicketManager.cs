 class TicketManager
    {
         // Specify the file paths for each CSV file
        private static string bugDefectsFile = "BugsDefects.csv";
        private static string enhancementsFile = "Enhancements.csv";
        private static string tasksFile = "Tasks.csv";
        public static void AddBugDefectTicket()
        {
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

            var bugDefectTicket = new BugDefectTicket(ticketID, summary, status, priority, submitter, assigned, watching, severity);
            
        }
                    //Engancement Ticket Data
                    public static void AddEnhancementTicket()
        {
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
            if (double.TryParse(Console.ReadLine(), out double cost))
            {
                Console.Write("Enter Reason: ");
                string reason = Console.ReadLine();
                Console.Write("Enter Estimate: ");
                if (double.TryParse(Console.ReadLine(), out double estimate))
                {
                    var enhancementTicket = new EnhancementTicket(ticketID, summary, status, priority, submitter, assigned, watching, software, cost, reason, estimate);

                    // Process and save the enhancement ticket data
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
                    // Task Ticket User input
    public static void AddTaskTicket()
        {
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
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                var taskTicket = new TaskTicket(ticketID, summary, status, priority, submitter, assigned, watching, projectName, dueDate);

                // Process and save the task ticket data
            }
            else
            {
                Console.WriteLine("Invalid Due Date format. Please enter a valid date (yyyy-MM-dd).");
            }
         }
     }