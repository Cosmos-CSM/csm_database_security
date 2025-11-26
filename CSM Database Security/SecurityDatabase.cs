using CSM_Database_Core;
using CSM_Database_Core.Abstractions.Interfaces;
using CSM_Database_Core.Core.Models;

using Microsoft.EntityFrameworkCore;

namespace CSM_Security_Database_Core;

/// <summary>
///     Represents a [CSM Security] database context.
/// </summary>
public class SecurityDatabase
    : DatabaseBase<SecurityDatabase>, IDatabase {

    /// <summary>
    ///     Database signature
    /// </summary>
    const string _SIGN = "CSMS";

    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    /// <param name="connectionOptions">
    ///     Connection options.
    /// </param>
    public SecurityDatabase(ConnectionOptions connectionOptions)
        : base(_SIGN, connectionOptions) {
    }

    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    /// <param name="dbContextOptions">
    ///     EF DbContext options.
    /// </param>
    public SecurityDatabase(DbContextOptions<SecurityDatabase> dbContextOptions)
        : base(_SIGN, dbContextOptions) { 
    }

    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    /// <param name="connectionOptions">
    ///     Connection options.
    /// </param>
    /// <param name="dbContextOptions">
    ///     EF DbContext options.
    /// </param>
    public SecurityDatabase(ConnectionOptions connectionOptions, DbContextOptions<SecurityDatabase> dbContextOptions)
        : base(_SIGN, connectionOptions, dbContextOptions) {
    }
}