using System.Text.Json.Serialization;
using Flatfile.net;

#nullable enable

namespace Flatfile.net;

public class Action
{
    /// <summary>
    /// **This is deprecated. Use `operation` instead.**
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; init; }

    /// <summary>
    /// This will become the job operation that is triggered
    /// </summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; init; }

    /// <summary>
    /// Foreground and toolbarBlocking action mode will prevent interacting with the resource until complete
    /// </summary>
    [JsonPropertyName("mode")]
    public ActionMode? Mode { get; init; }

    /// <summary>
    /// The text on the button itself.
    /// </summary>
    [JsonPropertyName("label")]
    public string Label { get; init; }

    /// <summary>
    /// A tooltip that appears when hovering the action button
    /// </summary>
    [JsonPropertyName("tooltip")]
    public string? Tooltip { get; init; }

    [JsonPropertyName("messages")]
    public IEnumerable<ActionMessage>? Messages { get; init; }

    /// <summary>
    /// **This is deprecated.**
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    /// <summary>
    /// The text that appears in the dialog after the action is clicked.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Determines if the action should happen on a regular cadence.
    /// </summary>
    [JsonPropertyName("schedule")]
    public ActionSchedule? Schedule { get; init; }

    /// <summary>
    /// A primary action will be more visibly present, whether in Sheet or Workbook.
    /// </summary>
    [JsonPropertyName("primary")]
    public bool? Primary { get; init; }

    /// <summary>
    /// Whether to show a modal to confirm the action
    /// </summary>
    [JsonPropertyName("confirm")]
    public bool? Confirm { get; init; }

    /// <summary>
    /// Icon will work on primary actions. It will only accept an already existing Flatfile design system icon.
    /// </summary>
    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    /// <summary>
    /// **This is deprecated. Use `constraints` instead.**
    /// </summary>
    [JsonPropertyName("requireAllValid")]
    public bool? RequireAllValid { get; init; }

    /// <summary>
    /// **This is deprecated. Use `constraints` instead.**
    /// </summary>
    [JsonPropertyName("requireSelection")]
    public bool? RequireSelection { get; init; }

    /// <summary>
    /// Adds an input form for this action after it is clicked.
    /// </summary>
    [JsonPropertyName("inputForm")]
    public InputForm? InputForm { get; init; }

    /// <summary>
    /// A limitation or restriction on the action.
    /// </summary>
    [JsonPropertyName("constraints")]
    public IEnumerable<ActionConstraint>? Constraints { get; init; }
}
