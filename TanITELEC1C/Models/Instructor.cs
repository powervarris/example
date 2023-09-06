﻿namespace TanITELEC1C.Models
{
    public enum Rank
    {

        Instructor, AsstProf, Prof

    }


    public class Instructor
    {

        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public String InstructorEmail { get; set; }
        public DateTime DateHired { get; set; }
        public Rank Rank { get; set; }
    }
}
