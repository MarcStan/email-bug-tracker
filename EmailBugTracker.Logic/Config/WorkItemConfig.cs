﻿namespace EmailBugTracker.Logic.Config
{
    public class WorkItemConfig
    {
        public DetermineTargetProjectVia DetermineTargetProjectVia { get; set; }

        public string Organization { get; set; }

        public string Project { get; set; }

        public string AuditContainerName { get; set; }
    }
}
