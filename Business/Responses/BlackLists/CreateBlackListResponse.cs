﻿namespace Business.Responses.BlackLists;

public class CreateBlackListResponse
{
    public int ApplicantId { get; set; }
    public string Reason { get; set; }
    public DateTime Date { get; set; }
}


