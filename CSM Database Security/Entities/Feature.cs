using CSM_Database_Core.Core.Attributes;

using CSM_Security_Database_Core.Abstractions.Bases;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CSM_Security_Database_Core.Entities;

/// <summary>
///     Represents an ecosystem complex feature.
/// </summary>
public interface IFeature {

    #region Properties

    bool IsEnabled { get; set; }

    #endregion

    #region Relations

    #endregion
}

/// <summary>
///     Represents an ecosystem complex feature.
/// </summary>
public class Feature
    : SecurityNamedEntityBase, IFeature {

    #region Properties
    public bool IsEnabled { get; set; }

    #endregion

    #region Dependants

    /// <summary>
    ///     <see cref="Permit"/> dependants from this <see cref="Feature"/>.
    /// </summary>
    [EntityRelation]
    public ICollection<Permit> Permits { get; set; } = [];

    #endregion

    protected override void DesignEntity(EntityTypeBuilder etBuilder) {
        etBuilder.Property(nameof(IsEnabled)).IsRequired();
    }
}
