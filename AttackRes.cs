using Godot;
using System;

[GlobalClass]
public partial class AttackRes : Resource
{
	  [Export]
	  public string Name { set; get; }

	  [Export(PropertyHint.MultilineText)]
	  public string Description { set; get; }

	  [Export]
	  public Texture2D Icon { set; get; }

	  [Export]
	  public PackedScene AttackScene { set; get; }
}
