namespace HealthChecks.Azure.Storage.Blobs;

/// <summary>
/// Represents a collection of settings that configure an
/// <see cref="AzureBlobStorageHealthCheck">Azure Storage Blob Service health check</see>.
/// </summary>
public sealed class AzureBlobStorageHealthCheckOptions
{
    /// <summary>
    /// Gets or sets the name of the Azure Storage container whose health should be checked.
    /// </summary>
    /// <remarks>
    /// If the value is <see langword="null"/>, then no health check is performed for a specific container.
    /// </remarks>
    /// <value>An optional Azure Storage container name.</value>
    public string? ContainerName { get; set; }

    /// <summary>
    /// Gets or sets the level of details on the health check report.
    /// </summary>
    /// <value>The level of details on the health check report.</value>
    public BlobHealthCheckReportLevel ReportLevel { get; set; } = BlobHealthCheckReportLevel.Standard;
}
