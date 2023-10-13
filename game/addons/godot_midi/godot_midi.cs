using Godot;
using System;

[Tool]
public partial class EditorPlugin {
	var import_plugin;

	public override void _enter_tree()
	{
		import_plugin = ResourceLoader.Load("midi_import_plugin.cs").new();
		GD.add_import_plugin(import_plugin);
	}

	public override void _exit_tree()
	{
		GD.remove_import_plugin(import_plugin);
		import_plugin = null;
	}
}
