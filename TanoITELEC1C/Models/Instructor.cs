namespace TanoITELEC1C.Models
{
    public enum Rank
    {
        Instructor, AssistantProfessor, AssociateProfessor, Professor
    }
    public class Instructor
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool isTenured { get; set; }

        public DateTime HiringDate { get; set; }
        public Rank Rank { get; set; }

    }
}