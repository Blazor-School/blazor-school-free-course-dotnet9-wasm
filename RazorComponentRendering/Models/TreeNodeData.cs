namespace RazorComponentRendering.Models;

public record TreeNodeData(string Name, List<TreeNodeData> Children);
