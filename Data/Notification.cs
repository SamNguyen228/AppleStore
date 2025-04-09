using System;
using System.Collections.Generic;

namespace WebsiteTMDT.Data;

public class Notification
{
    public int NotificationId { get; set; }
    public string Content { get; set; }
    public bool IsRead { get; set; } = false;
    public DateTime CreatedAt { get; set; }
}

