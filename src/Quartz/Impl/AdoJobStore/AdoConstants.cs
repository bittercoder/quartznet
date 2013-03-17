#region License
/* 
 * All content copyright Terracotta, Inc., unless otherwise indicated. All rights reserved. 
 * 
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not 
 * use this file except in compliance with the License. You may obtain a copy 
 * of the License at 
 * 
 *   http://www.apache.org/licenses/LICENSE-2.0 
 *   
 * Unless required by applicable law or agreed to in writing, software 
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT 
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the 
 * License for the specific language governing permissions and limitations 
 * under the License.
 * 
 */
#endregion

namespace Quartz.Impl.AdoJobStore
{
    /// <summary>
    /// This interface can be implemented by any <see cref="IDriverDelegate" />
    /// class that needs to use the constants contained herein.
    /// </summary>
    /// <author><a href="mailto:jeff@binaryfeed.org">Jeffrey Wescott</a></author>
    /// <author>James House</author>
    /// <author>Marko Lahma(.NET)</author>
    public class AdoConstants
    {
        // Table names
        public const string TableJobDetails = "job_details";
        public const string TableTriggers = "triggers";
        public const string TableSimpleTriggers = "simple_triggers";
        public const string TableCronTriggers = "cron_triggers";
        public const string TableBlobTriggers = "blob_triggers";
        public const string TableFiredTriggers = "fired_triggers";
        public const string TableCalendars = "calendars";
        public const string TablePausedTriggers = "paused_trigger_grps";
        public const string TableLocks = "locks";
        public const string TableSchedulerState = "scheduler_state";

        // TableJobDetails columns names
        public const string ColumnSchedulerName = "sched_name";
        public const string ColumnJobName = "job_name";
        public const string ColumnJobGroup = "job_group";
        public const string ColumnIsDurable = "is_durable";
        public const string ColumnIsVolatile = "is_volatile";
        public const string ColumnIsNonConcurrent = "is_nonconcurrent";
        public const string ColumnIsUpdateData = "is_update_data";
        public const string ColumnRequestsRecovery = "requests_recovery";
        public const string ColumnJobDataMap = "job_data";
        public const string ColumnJobClass = "job_class_name";
        public const string ColumnDescription = "description";

        // TableTriggers columns names
        public const string ColumnTriggerName = "trigger_name";
        public const string ColumnTriggerGroup = "trigger_group";
        public const string ColumnNextFireTime = "next_fire_time";
        public const string ColumnPreviousFireTime = "prev_fire_time";
        public const string ColumnTriggerState = "trigger_state";
        public const string ColumnTriggerType = "trigger_type";
        public const string ColumnStartTime = "start_time";
        public const string ColumnEndTime = "end_time";
        public const string ColumnMifireInstruction = "misfire_instr";
        public const string ColumnPriority = "priority";
        public const string AliasColumnNextFireTime = "alias_nxt_fr_tm";

        // TableSimpleTriggers columns names
        public const string ColumnRepeatCount = "repeat_count";
        public const string ColumnRepeatInterval = "repeat_interval";
        public const string ColumnTimesTriggered = "times_triggered";

        // TableCronTriggers columns names
        public const string ColumnCronExpression = "cron_expression";

        // TableBlobTriggers columns names
        public const string ColumnBlob = "blob_data";
        public const string ColumnTimeZoneId = "time_zone_id";

        // TableFiredTriggers columns names
        public const string ColumnInstanceName = "instance_name";
        public const string ColumnFiredTime = "fired_time";
        public const string ColumnEntryId = "entry_id";
        public const string ColumnEntryState = "state";

        // TableCalendars columns names
        public const string ColumnCalendarName = "calendar_name";
        public const string ColumnCalendar = "calendar";

        // TableLocks columns names
        public const string ColumnLockName = "lock_name";

        // TableLocks columns names
        public const string ColumnLastCheckinTime = "last_checkin_time";
        public const string ColumnCheckinInterval = "checkin_interval";

        // MISC CONSTANTS
        public const string DefaultTablePrefix = "QRTZ_";

        // STATES
        public const string StateWaiting = "WAITING";
        public const string StateAcquired = "ACQUIRED";
        public const string StateExecuting = "EXECUTING";
        public const string StateComplete = "COMPLETE";
        public const string StateBlocked = "BLOCKED";
        public const string StateError = "ERROR";
        public const string StatePaused = "PAUSED";
        public const string StatePausedBlocked = "PAUSED_BLOCKED";
        public const string StateDeleted = "DELETED";
        public const string AllGroupsPaused = "_$_ALL_GROUPS_PAUSED_$_";

        // TRIGGER TYPES
        public const string TriggerTypeSimple = "SIMPLE";
        public const string TriggerTypeCron = "CRON";
        public const string TriggerTypeCalendarInterval = "CAL_INT";
        public const string TriggerTypeBlob = "BLOB";
    }
}