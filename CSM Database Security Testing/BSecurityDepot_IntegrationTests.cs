using CSM_Database_Core.Depots.Abstractions.Interfaces;
using CSM_Database_Core.Entities.Abstractions.Interfaces;

using CSM_Database_Testing.Abstractions.Bases;
using CSM_Database_Testing.Disposing.Abstractions.Bases;

using CSM_Security_Database_Core;

namespace CSM_Security_Database_Testing;

/// <summary>
///     Represents an [CSM Database Security] integration tests base.
/// </summary>
/// <typeparam name="TEntity">
///     Type of the <see cref="IEntity"/> tests are based on.
/// </typeparam>
/// <typeparam name="TDepot">
///     Type of the <see cref="IDepot{IEntity}"/> tests are based on.    
/// </typeparam>
public abstract class BSecurityDepot_IntegrationTests<TEntity, TDepot>
    : TestingDepotBase<TEntity, TDepot, SecurityDatabase>
    where TEntity : class, IEntity, new()
    where TDepot : class, IDepot<TEntity> {

    /// <summary>
    ///     Creates a new instance.
    /// </summary>
    /// <param name="databaseFactory">
    ///     Factory for the main <typeparamref name="TEntity"/> database context handler to be used.
    /// </param>
    /// <param name="databaseFactories">
    ///     Collateral used databases factories to be used, this are usually needed when the <typeparamref name="TEntity"/> used has dependencies on a different <see cref="IDatabase"/> source than it's own context.
    /// </param>
    protected BSecurityDepot_IntegrationTests(
        DatabaseFactory? databaseFactory = null,
        params DatabaseFactory[] databaseFactories
    )
    : base("CSMS", databaseFactory, databaseFactories) {

    }
}
