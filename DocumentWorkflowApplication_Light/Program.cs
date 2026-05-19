using System.Reflection.Metadata;

namespace DocumentWorkflowApplication_Light
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var doc = new Document("Annual Report", "Initial draft content...");

            Console.WriteLine($"Initial state: {doc.CurrentState}\n");

            Console.WriteLine("--- Scenario 1: Happy path ---");
            doc.Edit("Updated content with more details");
            doc.Submit();
            doc.Approve();
            doc.Publish();
            doc.Archive();

            Console.WriteLine("\n--- Scenario 2: Rejection and rework ---");
            var doc2 = new Document("Project Proposal", "Initial proposal");
            doc2.Submit();
            doc2.Reject("Needs more financial details");
            doc2.Edit("Improved proposal with budget breakdown");
            doc2.Submit();
            doc2.Approve();
            doc2.Publish();

            Console.WriteLine("\n--- Scenario 3: Invalid actions ---");
            var doc3 = new Document("Test", "Test content");
            doc3.Approve();
            doc3.Publish();
            doc3.Archive();
            doc3.Submit();
            doc3.Edit("Cannot do this in review");
        }
    }
}
