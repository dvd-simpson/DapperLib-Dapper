﻿using System.Data;

#if DOTNET5_2
using IDbCommand = System.Data.Common.DbCommand;
#endif
namespace Dapper
{
    partial class SqlMapper
    {
        /// <summary>
        /// Implement this interface to pass an arbitrary db specific parameter to Dapper
        /// </summary>
        public interface ICustomQueryParameter
        {
            /// <summary>
            /// Add the parameter needed to the command before it executes
            /// </summary>
            /// <param name="command">The raw command prior to execution</param>
            /// <param name="name">Parameter name</param>
            void AddParameter(IDbCommand command, string name);
        }
    }
}
