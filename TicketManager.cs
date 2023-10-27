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
            using (StreamWriter writer = new StreamWriter(bugDefectsFile, true))
            {
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
            
            if (double.TryParse(Console.ReadLine(), out double enhancementCost))
            {
                Console.Write("Enter Reason: ");
                string reason = Console.ReadLine();
                Console.Write("Enter Estimate: ");
                if (double.TryParse(Console.ReadLine(), out double estimate))
                {
                    var enhancementTicket = new EnhancementTicket(ticketID, summary, status, priority, submitter, assigned, watching, software, cost, reason, estimate);


                    //Enhancement Ticket CVS File
                    using (StreamWriter writer = new StreamWriter(enhancementsFile, true))
                    {
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
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dueDate))
            {
                var taskTicket = new TaskTicket(ticketID, summary, status, priority, submitter, assigned, watching, projectName, dueDate);

                // Process and save the task ticket data
            }
            else
            {
                Console.WriteLine("Invalid Due Date format. Please enter a valid date (yyyy-MM-dd).");
            }
            using (StreamWriter writer = new StreamWriter(tasksFile, true))
            {
                TaskTicket taskTicket;
                if (DateTime.TryParse(Console.ReadLine(), out DateTime newDueDate))
                {
                    taskTicket = new TaskTicket(ticketID, summary, status, priority, submitter, assigned, watching, projectName, newDueDate);

                    writer.WriteLine($"{taskTicket.TicketID},{taskTicket.Summary},{taskTicket.Status},{taskTicket.Priority},{taskTicket.Submitter},{taskTicket.Assigned},{taskTicket.Watching},{taskTicket.ProjectName},{taskTicket.DueDate:yyyy-MM-dd}");

                    Console.WriteLine("Task Ticket added successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid Due Date format. Please enter a valid date (yyyy-MM-dd).");
                }
            }
        }
    }
