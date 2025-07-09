namespace HealthChecks.Azure.Storage.Blobs;

/// <summary>
/// Defines the level of details on the health check report.
/// </summary>
public enum BlobHealthCheckReportLevel
{
    /// <summary>
    /// No details.
    /// </summary>
    Standard,
    /// <summary>
    /// As many details as possible.
    /// </summary>
    Detailed
}
