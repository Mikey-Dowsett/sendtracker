﻿using System.Runtime.InteropServices.JavaScript;
using SQLite;

namespace SendTracker.Models;

public class Route {
    public Route() { }

    public Route(string sendName, string climbType, string grade, string technique, string attempts, string notes,
        string rockType, string photoPath, DateTime date) {
        SendName = sendName;
        ClimbType = climbType;
        Grade = grade;
        Technique = technique;
        Attempts = attempts;
        Notes = notes;
        RockType = rockType;
        PhotoPath = photoPath;
        Date = date;
    }

    [PrimaryKey] [AutoIncrement] public int Id { get; set; }
    public string SendName { get; set; }
    public string ClimbType { get; set; }
    public string Grade { get; set; }
    public string Technique { get; set; }
    public string Attempts { get; set; }
    public string Notes { get; set; }
    public string RockType { get; set; }
    public string PhotoPath { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan duration { get; set; }
    public int pitches { get; set; }

    public override string ToString() {
        return $"{SendName}, {ClimbType}, {Grade}";
    }
}