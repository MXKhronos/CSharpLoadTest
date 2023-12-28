using System.IO;
using Godot;

public partial class AutoLoad : Node {

    public AutoLoad() {
        var path = $"{Directory.GetParent(OS.GetExecutablePath())}/TestScript.cs";
        if (OS.HasFeature("editor")) {
            path = $"res://TestScript.cs";
        }
        
        GD.Print($"Loading Path: {path}");

        CSharpScript csTestScript = ResourceLoader.Load<CSharpScript>(path);
        csTestScript.New();

        GD.Print("Loaded");
    }
}