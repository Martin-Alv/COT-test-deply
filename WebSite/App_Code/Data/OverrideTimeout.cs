using System;
using System.Data.Common;

namespace eaton.Data
{
    public partial class Controller
    {
        protected override DbCommand CreateCommand(DataConnection connection)
        {
            DbCommand command = base.CreateCommand(connection);
            if(command != null)
            command.CommandTimeout = 60 * 5;
            return command;
        }
    }
}